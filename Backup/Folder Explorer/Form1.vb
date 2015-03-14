Imports System.IO
'main class
Public Class Form1
    'special declarations
    Const up = "⇧"
    Const down = "⇩"
    Const maxPath = 50
    'modified functions
#Region "Modified Functions"

    Function getSize(ByVal size As Decimal) As String
        Dim run As Integer = 0
        Dim entry() As String = {"B", "KB", "MB", "GB", "TB"}
        While size > 1024
            size /= 1024
            run += 1
        End While
        Dim res As String = FormatNumber(size, 2) & entry(run)
        Return res
    End Function

    Function DriveColor(ByVal type As DriveType) As Color
        Select Case type
            Case DriveType.CDRom
                Return Color.DarkRed
            Case DriveType.Fixed
                Return Color.Black
            Case DriveType.NoRootDirectory
                Return Color.Gray
            Case DriveType.Ram
                Return Color.DarkBlue
            Case DriveType.Unknown
                Return Color.DarkSlateGray
            Case DriveType.Removable
                Return Color.DarkMagenta
            Case Else
                Return Color.Teal
        End Select
    End Function

    Function PathColor(ByVal type As FileAttributes) As Color
        Dim tp As String = type.ToString()
        If tp.Contains("System") Then
            Return Color.DarkOrange
        ElseIf tp.Contains("Hidden") Then
            Return Color.Gray
        ElseIf tp.Contains("Compressed") Or tp.Contains("Archive") Then
            Return Color.Maroon
        ElseIf tp.Contains("ReadOnly") Then
            Return Color.Navy
        Else
            Return Color.Black
        End If
    End Function
#End Region

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.History = CType(FolderPath1.Items, Object)
        My.Settings.largeSize = ToolStripComboBox1.SelectedIndex
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load settings
        ToolStripComboBox1.SelectedIndex = My.Settings.largeSize
        If Not My.Settings.History Is Nothing Then FolderPath1.Items.AddRange(My.Settings.History)
        'others
        loadDrives()
    End Sub

#Region "Top Folder List"


    Sub loadDrives()
        TopFolderList.Nodes.Clear()
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            Dim node As New TreeNode
            node.Tag = drive.Name
            'add text
            Dim lbl As String = ""
            Try
                lbl = drive.VolumeLabel
                If lbl = "" Then lbl = drive.DriveType.ToString() & " Drive"
            Catch
                lbl = "Unknown"
            End Try
            node.Text = drive.Name & lbl
            'set tooptip
            Try
                node.ToolTipText &= "Type: " & drive.DriveType.ToString & vbCrLf _
                    & "Format: " & drive.DriveFormat & vbCrLf _
                    & "Total Size: " & getSize(drive.TotalSize) & vbCrLf _
                    & "Free Space: " & getSize(drive.AvailableFreeSpace)
            Catch
                node.ToolTipText &= "Type: " & drive.DriveType.ToString & vbCrLf _
                    & "Format: Unknown" & vbCrLf & "Size: 0B" & vbCrLf & "Size: 0B"
            End Try
            'set style
            node.ForeColor = DriveColor(drive.DriveType)
            'set image
            If drive.DriveType = DriveType.Fixed Then
                node.ImageKey = "internalDrive"
                node.SelectedImageKey = "internalDrive"
            ElseIf drive.DriveType = DriveType.CDRom Then
                node.ImageKey = "cdDrive"
                node.SelectedImageKey = "cdDrive"
            Else
                node.ImageKey = "externalDrive"
                node.SelectedImageKey = "externalDrive"
            End If
            'add node   
            LoadSubFolderTree(node)
            TopFolderList.Nodes.Add(node)
        Next
    End Sub

    Private Sub TopFolderList_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TopFolderList.AfterSelect
        Try
            Dim node As TreeNode = TopFolderList.SelectedNode
            If node.Tag = TopFolderList.Tag Then Exit Sub
            TopFolderList.Tag = node.Tag
            If node.Nodes.Count = 0 Then LoadSubFolderTree(node)
            LoadFilesList(node.Tag)
        Catch ex As Exception
            Status1.Text = ex.Message
        End Try
    End Sub

    Private Sub TopFolderList_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TopFolderList.NodeMouseClick
        If e.Node.IsExpanded Then
            e.Node.Collapse()
        Else
            If e.Node.Nodes.Count = 0 Then LoadSubFolderTree(e.Node)
            e.Node.Expand()
        End If
    End Sub

    Sub LoadSubFolderTree(ByVal tnode As TreeNode)
        If tnode.Nodes.Count > 0 Then tnode.Nodes.Clear()
        Try
            For Each itm In My.Computer.FileSystem.GetDirectories(tnode.Tag)
                Dim folder As New DirectoryInfo(itm)
                'add node
                Dim node As TreeNode = newNode(folder)
                tnode.Nodes.Add(node)
            Next
        Catch : End Try
    End Sub

    'create a new node
    Function newNode(ByVal folder As DirectoryInfo) As TreeNode
        Dim node As New TreeNode
        node.Text = folder.Name
        node.Tag = folder.ToString
        'image key
        node.ImageKey = "closeFolder"
        'get tooptip
        node.ToolTipText &= "Name: " & folder.Name & vbCrLf
        node.ToolTipText &= "Attributes: " & folder.Attributes.ToString() & vbCrLf
        Try
            Dim dirc As Integer = folder.GetDirectories.Length
            Dim filc As Integer = folder.GetFiles.Length
            node.ToolTipText &= "Directory Count: " & dirc & vbCrLf
            node.ToolTipText &= "Files Count: " & filc & vbCrLf
            node.ToolTipText &= "Accessible" & vbCrLf
            'set image
            If dirc = 0 And filc > 0 Then : node.SelectedImageKey = "fileFolder"
            Else : node.SelectedImageKey = "emptyFolder" : End If
        Catch ex As Exception
            Status1.Text = ex.Message
            node.ToolTipText &= "Inaccessible" & vbCrLf
            node.SelectedImageKey = "emptyFolder"
        End Try
        node.ToolTipText &= folder.ToString
        'set styles
        node.ForeColor = PathColor(folder.Attributes)
        Return node
    End Function

#End Region

#Region "FileList view"

#Region "Load Files"

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim files As ObjectModel.ReadOnlyCollection(Of String)
        Try
            Files = My.Computer.FileSystem.GetFiles(e.Argument)
        Catch ex As Exception
            Status1.Text = ex.Message
            e.Cancel = True
            Exit Sub
        End Try
        'show files
        For i = 0 To files.Count - 1
            If BackgroundWorker1.CancellationPending Then e.Cancel = True
            Dim file As New FileInfo(files(i))
            Dim litm As New ListViewItem(New String() {"", "", "", "", "", "", "", ""})
            litm.Tag = files(i)
            'get items
            litm.Text = file.Name
            litm.SubItems(1).Text = file.Attributes.ToString()
            litm.SubItems(2).Text = getSize(file.Length)
            litm.SubItems(3).Text = file.Extension
            litm.SubItems(4).Text = file.CreationTime
            litm.SubItems(5).Text = file.LastAccessTime
            litm.SubItems(6).Text = file.LastWriteTime
            litm.SubItems(7).Text = files(i)
            'set styles
            litm.UseItemStyleForSubItems = False
            litm.SubItems(0).ForeColor = PathColor(file.Attributes)
            litm.SubItems(0).Font = New Font("Segoe UI Semibold", 10)
            'add image
            Dim key As String = "img" & i
            Dim img As Bitmap = Nothing
            Try
                img = New Bitmap(litm.Tag.ToString)
            Catch ex As Exception
                key = "img" & litm.SubItems(3).Text
                img = Icon.ExtractAssociatedIcon(litm.Tag).ToBitmap()
            End Try
            'report progress
            BackgroundWorker1.ReportProgress(i, New Object() {litm, img, key})
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'add image
        Dim img As Object = e.UserState(1)
        Dim key As String = e.UserState(2)
        If LargeImageList.Images(key) Is Nothing Then
            SmallImageList.Images.Add(key, img)
            LargeImageList.Images.Add(key, img)
        End If
        'get item
        Dim litm As ListViewItem = e.UserState(0)
        litm.ImageKey = key
        'add tooltip
        Dim txt As String = ""
        For i = 0 To litm.SubItems.Count - 1
            txt &= FileList.Columns(i).Text & ": " & litm.SubItems(i).Text & vbCrLf
        Next
        litm.ToolTipText = txt
        'add item
        FileList.Items.Add(litm).Group = FileList.Groups("File")
        'progress changed
        Dim per As Integer = (e.ProgressPercentage * 100) / 100
        If per < 100 Then Progress1.Value = per
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Not BackgroundWorker2.IsBusy Then
            Progress1.Value = 0
            Progress1.Visible = False
            FileList.Enabled = True
        End If
    End Sub
#End Region

#Region "Load Folders"

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim files As ObjectModel.ReadOnlyCollection(Of String)
        Try
            files = My.Computer.FileSystem.GetDirectories(e.Argument)
        Catch ex As Exception
            Status1.Text = ex.Message
            e.Cancel = True
            Exit Sub
        End Try
        'show files
        For i = 0 To files.Count - 1
            If BackgroundWorker2.CancellationPending Then e.Cancel = True
            Dim folder As New DirectoryInfo(files(i))
            Dim key As String = "emptyFolder"
            Dim litm As New ListViewItem(New String() {"", "", "", "", "", "", "", ""})
            litm.Tag = files(i)
            'get items
            litm.Text = folder.Name
            litm.SubItems(1).Text = folder.Attributes.ToString()
            litm.SubItems(2).Text = "~"
            litm.SubItems(3).Text = "~"
            litm.SubItems(4).Text = folder.CreationTime
            litm.SubItems(5).Text = folder.LastAccessTime
            litm.SubItems(6).Text = folder.LastWriteTime
            litm.SubItems(7).Text = files(i)
            'get tooptip
            litm.ToolTipText &= "Name: " & folder.Name & vbCrLf
            litm.ToolTipText &= "Attributes: " & folder.Attributes.ToString() & vbCrLf
            Try
                Dim dirc As Integer = folder.GetDirectories.Length
                Dim filc As Integer = folder.GetFiles.Length
                litm.ToolTipText &= "Directory Count: " & dirc & vbCrLf
                litm.ToolTipText &= "Files Count: " & filc & vbCrLf
                litm.ToolTipText &= "Accessible" & vbCrLf
                'set image
                If dirc > 0 Then
                    key = "folderFolder"
                Else
                    If filc > 0 Then key = "fileFolder"
                End If
            Catch ex As Exception
                'Status1.Text = ex.Message
                litm.ToolTipText &= "Inaccessible" & vbCrLf
            End Try
            'set styles
            litm.UseItemStyleForSubItems = False
            litm.SubItems(0).ForeColor = PathColor(folder.Attributes)
            litm.SubItems(0).Font = New Font("Segoe UI Semibold", 10)
            'report progress
            BackgroundWorker2.ReportProgress(i, New Object() {litm, key})
        Next
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        'add item
        Dim litm As ListViewItem = e.UserState(0)
        litm.ImageKey = e.UserState(1)
        FileList.Items.Add(litm).Group = FileList.Groups("Folder")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If Not BackgroundWorker1.IsBusy Then
            Progress1.Value = 0
            Progress1.Visible = False
            FileList.Enabled = True
        End If
    End Sub

#End Region

    Sub LoadFilesList(ByVal path As String)
        FolderPath1.SelectedIndex = -1
        If Not FolderPath1.Items(0) = path Then FolderPath1.Items.Insert(0, path)
        FolderPath1.SelectedIndex = 0
        If FolderPath1.Items.Count > maxPath Then
            FolderPath1.Items.RemoveAt(maxPath)
        End If
    End Sub

    Private Sub TLP2_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableLayoutPanel2.SizeChanged
        Try : FolderPath1.Size = New Size(ToolStrip1.Width - 80, 23) : Catch : End Try
    End Sub

    Private Sub FileList_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileList.ItemActivate
        Try
            Process.Start(FileList.FocusedItem.Tag)
        Catch ex As Exception
            MsgBox(ex.Message)
            Status1.Text = ex.Message
        End Try
    End Sub

#End Region

#Region "Folder Path"

    'folder Path: Recently browsed folders
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            LoadFilesList(FolderPath1.Text)
        Catch ex As Exception
            Status1.Text = ex.Message
        End Try
    End Sub

    Private Sub FolderPath1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FolderPath1.KeyUp
        If e.KeyCode = Keys.Enter Then ToolStripButton1.PerformClick()
    End Sub

    Private Sub FolderPath1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FolderPath1.SelectedIndexChanged
        Try
            If FolderPath1.SelectedIndex = -1 Then Exit Sub
            Dim txt As String = FolderPath1.SelectedItem.ToString()
            If Not Directory.Exists(txt) Then Exit Sub
            FileList.Items.Clear()
            BackgroundWorker1.CancelAsync()
            BackgroundWorker2.CancelAsync()
            SmallImageList.Images.Clear()
            LargeImageList.Images.Clear()
            'add image
            SmallImageList.Images.Add("emptyFolder", FolderImageList.Images("emptyFolder"))
            SmallImageList.Images.Add("fileFolder", FolderImageList.Images("fileFolder"))
            SmallImageList.Images.Add("folderFolder", FolderImageList.Images("topFolder"))
            LargeImageList.Images.Add("emptyFolder", My.Resources.emptyFolder.ToBitmap)
            LargeImageList.Images.Add("fileFolder", My.Resources.fileFolder.ToBitmap)
            LargeImageList.Images.Add("folderFolder", My.Resources.floders.ToBitmap)
            'run worker
            If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync(txt)
            If FolderShow.Text = "Folder(Showed)" Then
                If Not BackgroundWorker2.IsBusy Then BackgroundWorker2.RunWorkerAsync(txt)
            End If
            Progress1.Visible = True
            FileList.Enabled = False
            FileList.Tag = txt
        Catch : End Try
    End Sub

    Private Sub Back1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back1.Click
        If Not FolderPath1.SelectedIndex = FolderPath1.Items.Count - 1 Then
            FolderPath1.SelectedIndex += 1
        End If
    End Sub

    Private Sub Previous1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Previous1.Click
        If Not FolderPath1.SelectedIndex < 1 Then
            FolderPath1.SelectedIndex -= 1
        End If
    End Sub

    Private Sub ViewAsItm_Click(ByVal sender As System.Windows.Forms.ToolStripMenuItem, ByVal e As System.EventArgs) Handles ViewAsItm0.Click, ViewAsItm1.Click, ViewAsItm2.Click, ViewAsItm3.Click, ViewAsItm4.Click
        Dim prv As ToolStripMenuItem = ViewAsList.DropDownItems(FileList.View)
        prv.Checked = False
        Dim p As Integer = sender.Name(sender.Name.Length - 1).ToString()
        FileList.View = p
        ViewAsList.Image = sender.Image
        sender.Checked = True
    End Sub

#End Region

#Region "Search"

    Private Sub TextBox1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBox.GotFocus
        Dim tb As TextBox = sender
        If tb.Text = "Search" Then
            tb.Text = ""
            tb.ForeColor = Color.Black
            tb.Font = New Font(tb.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.LostFocus
        Dim tb As TextBox = sender
        If tb.Text.Trim = "" Then
            tb.Text = "Search"
            tb.ForeColor = Color.Gray
            tb.Font = New Font(tb.Font, FontStyle.Italic)
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            If SearchBox.Tag = 0 Then
                Dim src As String = SearchBox.Text.ToLower.Trim
                FileList.SelectedItems.Clear()
                For Each itm As ListViewItem In FileList.Items
                    Dim txt As String = itm.Text.ToLower
                    If txt.Contains(src) Then
                        itm.Selected = True
                        itm.EnsureVisible()
                        Exit For
                    End If
                Next
            Else
                specialSearch()
            End If
        End If
    End Sub

    Sub specialSearch()
        'get data
        Dim ssub, mcatch, mwhole, mcontent As Boolean
        Dim srctxt, sin, stype As String
        ssub = SearchSub.Checked
        mcatch = MatchCatch.Checked
        mwhole = MatchWhole.Checked
        sin = SearchIn.Text
        stype = TypeCombo.Text
        srctxt = SearchBox.Text.ToLower

        'All Types
        'Musics
        'Videos
        'Images
        'Programs
        'Documents
        'Others


        If Not mcatch Then srctxt = srctxt.ToLower

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = down Then
            Button1.Text = up
            TableLayoutPanel2.RowStyles.Item(1).Height = 120
            SearchBox.Tag = 0
        ElseIf Button1.Text = up Then
            Button1.Text = down
            TableLayoutPanel2.RowStyles.Item(1).Height = 32
            SearchBox.Tag = 1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fbd As New FolderBrowserDialog
        If Not SearchIn.Text = "" Then fbd.SelectedPath = SearchIn.Text
        fbd.Description = "Select a path to search into."
        If fbd.ShowDialog Then
            SearchIn.Text = fbd.SelectedPath
        End If
    End Sub
#End Region

    Private Sub ToolStripButton2_Click(ByVal sender As ToolStripButton, ByVal e As System.EventArgs) Handles FolderShow.Click
        If sender.Text = "Folder(Showed)" Then
            sender.Text = "Folder(Hided)"
            sender.Image = My.Resources.cross
        Else
            sender.Text = "Folder(Showed)"
            sender.Image = My.Resources.Icon_145
        End If
        FolderPath1.SelectedIndex = -1
        FolderPath1.SelectedIndex = 0
    End Sub

    Private Sub ToolStripComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim txt As String = ToolStripComboBox1.Text.Trim
            If txt.Contains("*") Then
                ToolStripComboBox1.Items.Insert(0, txt)
                ToolStripComboBox1.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            FolderPath1.SelectedIndex = -1
            Dim sz() As String = Split(ToolStripComboBox1.SelectedItem, "*")
            LargeImageList.ImageSize = New Size(sz(0), sz(1))
            FolderPath1.SelectedIndex = 0
            FileList.TileSize = New Size(sz(0) + 100, sz(1) + 10)
        Catch ex As Exception
            Status1.Text = ex.Message
            Dim sz As Size = LargeImageList.ImageSize
            ToolStripComboBox1.Text = sz.Width & "*" & sz.Height
        End Try
    End Sub
End Class
