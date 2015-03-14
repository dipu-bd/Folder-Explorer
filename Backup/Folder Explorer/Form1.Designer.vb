<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left)
        Me.FolderImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.FileList = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SearchBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TypeCombo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SearchIn = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.MatchWhole = New System.Windows.Forms.CheckBox
        Me.MatchCatch = New System.Windows.Forms.CheckBox
        Me.SearchSub = New System.Windows.Forms.CheckBox
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ViewAsList = New System.Windows.Forms.ToolStripDropDownButton
        Me.ViewAsItm0 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAsItm1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAsItm2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAsItm3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAsItm4 = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderShow = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Progress1 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Back1 = New System.Windows.Forms.ToolStripButton
        Me.Previous1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.FolderPath1 = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.TopFolderList = New System.Windows.Forms.TreeView
        Me.Label2 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FolderImageList
        '
        Me.FolderImageList.ImageStream = CType(resources.GetObject("FolderImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FolderImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.FolderImageList.Images.SetKeyName(0, "externalDrive")
        Me.FolderImageList.Images.SetKeyName(1, "internalDrive")
        Me.FolderImageList.Images.SetKeyName(2, "cdDrive")
        Me.FolderImageList.Images.SetKeyName(3, "topFolder")
        Me.FolderImageList.Images.SetKeyName(4, "fileFolder")
        Me.FolderImageList.Images.SetKeyName(5, "emptyFolder")
        Me.FolderImageList.Images.SetKeyName(6, "closeFolder")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FileList, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip2, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(480, 395)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'FileList
        '
        Me.FileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader21, Me.ColumnHeader23, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader22})
        Me.FileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileList.FullRowSelect = True
        ListViewGroup1.Header = "Files"
        ListViewGroup1.Name = "File"
        ListViewGroup2.Header = "Folders"
        ListViewGroup2.Name = "Folder"
        Me.FileList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.FileList.HideSelection = False
        Me.FileList.LargeImageList = Me.LargeImageList
        Me.FileList.Location = New System.Drawing.Point(3, 148)
        Me.FileList.Name = "FileList"
        Me.FileList.ShowItemToolTips = True
        Me.FileList.Size = New System.Drawing.Size(474, 244)
        Me.FileList.SmallImageList = Me.SmallImageList
        Me.FileList.TabIndex = 6
        Me.FileList.TileSize = New System.Drawing.Size(180, 52)
        Me.FileList.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Name"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Attributes"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Size"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Extension"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Creation"
        Me.ColumnHeader18.Width = 125
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Last Access"
        Me.ColumnHeader19.Width = 125
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Last Write"
        Me.ColumnHeader20.Width = 125
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Path"
        '
        'LargeImageList
        '
        Me.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LargeImageList.ImageSize = New System.Drawing.Size(48, 48)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'SmallImageList
        '
        Me.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.SmallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(474, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Files"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SearchBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 94)
        Me.Panel2.TabIndex = 6
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.Gray
        Me.SearchBox.Location = New System.Drawing.Point(3, 0)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(442, 25)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.Tag = "0"
        Me.SearchBox.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(448, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "⇩"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TypeCombo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.SearchIn)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.MatchWhole)
        Me.GroupBox3.Controls.Add(Me.MatchCatch)
        Me.GroupBox3.Controls.Add(Me.SearchSub)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 68)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Advance Search"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(332, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Windows Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TypeCombo
        '
        Me.TypeCombo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeCombo.FormattingEnabled = True
        Me.TypeCombo.Items.AddRange(New Object() {"All Types", "Musics", "Videos", "Images", "Programs", "Documents", "Others"})
        Me.TypeCombo.Location = New System.Drawing.Point(207, 42)
        Me.TypeCombo.Name = "TypeCombo"
        Me.TypeCombo.Size = New System.Drawing.Size(93, 21)
        Me.TypeCombo.TabIndex = 8
        Me.TypeCombo.Text = "All Types"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Type :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(434, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SearchIn
        '
        Me.SearchIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIn.Location = New System.Drawing.Point(207, 16)
        Me.SearchIn.Name = "SearchIn"
        Me.SearchIn.ReadOnly = True
        Me.SearchIn.Size = New System.Drawing.Size(224, 22)
        Me.SearchIn.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Look In :"
        '
        'MatchWhole
        '
        Me.MatchWhole.AutoSize = True
        Me.MatchWhole.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatchWhole.Location = New System.Drawing.Point(6, 50)
        Me.MatchWhole.Name = "MatchWhole"
        Me.MatchWhole.Size = New System.Drawing.Size(118, 17)
        Me.MatchWhole.TabIndex = 3
        Me.MatchWhole.Text = "Match Whole Text"
        Me.MatchWhole.UseVisualStyleBackColor = True
        '
        'MatchCatch
        '
        Me.MatchCatch.AutoSize = True
        Me.MatchCatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatchCatch.Location = New System.Drawing.Point(6, 34)
        Me.MatchCatch.Name = "MatchCatch"
        Me.MatchCatch.Size = New System.Drawing.Size(90, 17)
        Me.MatchCatch.TabIndex = 1
        Me.MatchCatch.Text = "Match Catch"
        Me.MatchCatch.UseVisualStyleBackColor = True
        '
        'SearchSub
        '
        Me.SearchSub.AutoSize = True
        Me.SearchSub.Checked = True
        Me.SearchSub.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SearchSub.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchSub.Location = New System.Drawing.Point(6, 18)
        Me.SearchSub.Name = "SearchSub"
        Me.SearchSub.Size = New System.Drawing.Size(141, 17)
        Me.SearchSub.TabIndex = 0
        Me.SearchSub.Text = "Search Sub Directories"
        Me.SearchSub.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ViewAsList, Me.FolderShow, Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 120)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(480, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripDropDownButton1.Text = "Group By"
        '
        'ViewAsList
        '
        Me.ViewAsList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAsItm0, Me.ViewAsItm1, Me.ViewAsItm2, Me.ViewAsItm3, Me.ViewAsItm4})
        Me.ViewAsList.Image = Global.Folder_Explorer.My.Resources.Resources.large
        Me.ViewAsList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewAsList.Name = "ViewAsList"
        Me.ViewAsList.Size = New System.Drawing.Size(61, 22)
        Me.ViewAsList.Text = "View"
        '
        'ViewAsItm0
        '
        Me.ViewAsItm0.Checked = True
        Me.ViewAsItm0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewAsItm0.Image = Global.Folder_Explorer.My.Resources.Resources.large
        Me.ViewAsItm0.Name = "ViewAsItm0"
        Me.ViewAsItm0.Size = New System.Drawing.Size(134, 22)
        Me.ViewAsItm0.Text = "Large Icons"
        '
        'ViewAsItm1
        '
        Me.ViewAsItm1.Image = Global.Folder_Explorer.My.Resources.Resources.details
        Me.ViewAsItm1.Name = "ViewAsItm1"
        Me.ViewAsItm1.Size = New System.Drawing.Size(134, 22)
        Me.ViewAsItm1.Text = "Details"
        '
        'ViewAsItm2
        '
        Me.ViewAsItm2.Image = Global.Folder_Explorer.My.Resources.Resources.small
        Me.ViewAsItm2.Name = "ViewAsItm2"
        Me.ViewAsItm2.Size = New System.Drawing.Size(134, 22)
        Me.ViewAsItm2.Text = "Small Icons"
        '
        'ViewAsItm3
        '
        Me.ViewAsItm3.Image = Global.Folder_Explorer.My.Resources.Resources.list
        Me.ViewAsItm3.Name = "ViewAsItm3"
        Me.ViewAsItm3.Size = New System.Drawing.Size(134, 22)
        Me.ViewAsItm3.Text = "List"
        '
        'ViewAsItm4
        '
        Me.ViewAsItm4.Image = Global.Folder_Explorer.My.Resources.Resources.tile
        Me.ViewAsItm4.Name = "ViewAsItm4"
        Me.ViewAsItm4.Size = New System.Drawing.Size(134, 22)
        Me.ViewAsItm4.Text = "Tiles"
        '
        'FolderShow
        '
        Me.FolderShow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FolderShow.Image = Global.Folder_Explorer.My.Resources.Resources.Icon_145
        Me.FolderShow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FolderShow.Name = "FolderShow"
        Me.FolderShow.Size = New System.Drawing.Size(110, 22)
        Me.FolderShow.Text = "Folder(Showed)"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Image Size:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"24*24", "32*32", "48*48", "64*64", "96*96", "128*128", "196*196", "256*256"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(75, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.Progress1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(480, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.Status1.Size = New System.Drawing.Size(465, 17)
        Me.Status1.Spring = True
        Me.Status1.Text = "Status"
        Me.Status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Progress1
        '
        Me.Progress1.Name = "Progress1"
        Me.Progress1.Size = New System.Drawing.Size(100, 16)
        Me.Progress1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Back1, Me.Previous1, Me.ToolStripSeparator1, Me.FolderPath1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(480, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Back1
        '
        Me.Back1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Back1.Image = CType(resources.GetObject("Back1.Image"), System.Drawing.Image)
        Me.Back1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Back1.Name = "Back1"
        Me.Back1.Size = New System.Drawing.Size(23, 22)
        Me.Back1.Text = "ToolStripButton1"
        '
        'Previous1
        '
        Me.Previous1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Previous1.Image = CType(resources.GetObject("Previous1.Image"), System.Drawing.Image)
        Me.Previous1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Previous1.Name = "Previous1"
        Me.Previous1.Size = New System.Drawing.Size(23, 22)
        Me.Previous1.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'FolderPath1
        '
        Me.FolderPath1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FolderPath1.Items.AddRange(New Object() {"Nothing"})
        Me.FolderPath1.Name = "FolderPath1"
        Me.FolderPath1.Size = New System.Drawing.Size(400, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Folder_Explorer.My.Resources.Resources.arrow_right_blue
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "GO"
        '
        'TopFolderList
        '
        Me.TopFolderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopFolderList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopFolderList.ImageIndex = 6
        Me.TopFolderList.ImageList = Me.FolderImageList
        Me.TopFolderList.Location = New System.Drawing.Point(0, 18)
        Me.TopFolderList.Name = "TopFolderList"
        Me.TopFolderList.SelectedImageIndex = 5
        Me.TopFolderList.ShowLines = False
        Me.TopFolderList.ShowNodeToolTips = True
        Me.TopFolderList.Size = New System.Drawing.Size(177, 424)
        Me.TopFolderList.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Purple
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Top Folders"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TopFolderList)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer3.Size = New System.Drawing.Size(661, 442)
        Me.SplitContainer3.SplitterDistance = 177
        Me.SplitContainer3.TabIndex = 0
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 442)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Folder Explorer Plus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TopFolderList As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FileList As System.Windows.Forms.ListView
    Friend WithEvents Back1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Previous1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderPath1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SmallImageList As System.Windows.Forms.ImageList
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Progress1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchSub As System.Windows.Forms.CheckBox
    Friend WithEvents MatchCatch As System.Windows.Forms.CheckBox
    Friend WithEvents MatchWhole As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SearchIn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FolderImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Public WithEvents LargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewAsList As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewAsItm0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAsItm1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAsItm2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAsItm3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAsItm4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderShow As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox

End Class
