Partial Public Class frm_Main

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Write As System.Windows.Forms.Button
    Friend WithEvents btn_Load As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cms_Frames = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Write = New System.Windows.Forms.Button
        Me.btn_Load = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btn_DeletePicture = New System.Windows.Forms.Button
        Me.btn_AddPictures = New System.Windows.Forms.Button
        Me.pbx_Picture = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_ProtectionFlag = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_PrivateFlag = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_OriginalFlag = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_CopyrightFlag = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_Level = New System.Windows.Forms.TextBox
        Me.txt_Frequency = New System.Windows.Forms.TextBox
        Me.txt_Size = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_Duration = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_BitRate = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_Mode = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_Layer = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbxVBR = New System.Windows.Forms.CheckBox
        Me.grp_ID3v2 = New System.Windows.Forms.GroupBox
        Me.chk_IsCoverV2 = New System.Windows.Forms.CheckBox
        Me.chk_IsRemixV2 = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_TrackCountV2 = New System.Windows.Forms.TextBox
        Me.cmb_GenreV2 = New System.Windows.Forms.ComboBox
        Me.txt_TrackNumV2 = New System.Windows.Forms.TextBox
        Me.txt_AlbumV2 = New System.Windows.Forms.TextBox
        Me.txt_CommentsV2 = New System.Windows.Forms.TextBox
        Me.txt_TitleV2 = New System.Windows.Forms.TextBox
        Me.txt_ArtistV2 = New System.Windows.Forms.TextBox
        Me.txt_YearV2 = New System.Windows.Forms.TextBox
        Me.grp_ID3v1 = New System.Windows.Forms.GroupBox
        Me.cmb_GenreV1 = New System.Windows.Forms.ComboBox
        Me.txt_YearV1 = New System.Windows.Forms.TextBox
        Me.txt_AlbumV1 = New System.Windows.Forms.TextBox
        Me.txt_ArtistV1 = New System.Windows.Forms.TextBox
        Me.txt_CommentsV1 = New System.Windows.Forms.TextBox
        Me.txt_TrackNumV1 = New System.Windows.Forms.TextBox
        Me.txt_TitleV1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_WriteID3v1Tag = New System.Windows.Forms.CheckBox
        Me.chk_WriteID3v2Tag = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cms_Frames.SuspendLayout()
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_ID3v2.SuspendLayout()
        Me.grp_ID3v1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_Frames
        '
        Me.cms_Frames.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFrameToolStripMenuItem})
        Me.cms_Frames.Name = "cms_Frames"
        Me.cms_Frames.ShowImageMargin = False
        Me.cms_Frames.Size = New System.Drawing.Size(175, 26)
        '
        'DeleteFrameToolStripMenuItem
        '
        Me.DeleteFrameToolStripMenuItem.Name = "DeleteFrameToolStripMenuItem"
        Me.DeleteFrameToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteFrameToolStripMenuItem.Text = "Delete Seleced Frame(s)"
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Close.Location = New System.Drawing.Point(584, 560)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(80, 24)
        Me.btn_Close.TabIndex = 27
        Me.btn_Close.Text = "Close"
        '
        'btn_Write
        '
        Me.btn_Write.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Write.Enabled = False
        Me.btn_Write.Location = New System.Drawing.Point(496, 560)
        Me.btn_Write.Name = "btn_Write"
        Me.btn_Write.Size = New System.Drawing.Size(80, 24)
        Me.btn_Write.TabIndex = 26
        Me.btn_Write.Text = "Write"
        '
        'btn_Load
        '
        Me.btn_Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Load.Location = New System.Drawing.Point(408, 560)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(80, 24)
        Me.btn_Load.TabIndex = 28
        Me.btn_Load.Text = "Open"
        '
        'btn_DeletePicture
        '
        Me.btn_DeletePicture.Enabled = False
        Me.btn_DeletePicture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DeletePicture.Location = New System.Drawing.Point(184, 206)
        Me.btn_DeletePicture.Name = "btn_DeletePicture"
        Me.btn_DeletePicture.Size = New System.Drawing.Size(56, 23)
        Me.btn_DeletePicture.TabIndex = 81
        Me.btn_DeletePicture.Text = "Delete"
        Me.btn_DeletePicture.UseVisualStyleBackColor = False
        '
        'btn_AddPictures
        '
        Me.btn_AddPictures.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddPictures.Location = New System.Drawing.Point(6, 206)
        Me.btn_AddPictures.Name = "btn_AddPictures"
        Me.btn_AddPictures.Size = New System.Drawing.Size(56, 23)
        Me.btn_AddPictures.TabIndex = 80
        Me.btn_AddPictures.Text = "Add"
        Me.btn_AddPictures.UseVisualStyleBackColor = False
        '
        'pbx_Picture
        '
        Me.pbx_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbx_Picture.Location = New System.Drawing.Point(27, 19)
        Me.pbx_Picture.Name = "pbx_Picture"
        Me.pbx_Picture.Size = New System.Drawing.Size(200, 200)
        Me.pbx_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Picture.TabIndex = 78
        Me.pbx_Picture.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 243)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ProtectionFlag)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_PrivateFlag)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_OriginalFlag)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_CopyrightFlag)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txt_Level)
        Me.GroupBox3.Controls.Add(Me.txt_Frequency)
        Me.GroupBox3.Controls.Add(Me.txt_Size)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txt_Duration)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txt_BitRate)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_Mode)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txt_Layer)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.cbxVBR)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 221)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MPEG"
        '
        'txt_ProtectionFlag
        '
        Me.txt_ProtectionFlag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_ProtectionFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ProtectionFlag.Location = New System.Drawing.Point(104, 184)
        Me.txt_ProtectionFlag.Name = "txt_ProtectionFlag"
        Me.txt_ProtectionFlag.ReadOnly = True
        Me.txt_ProtectionFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_ProtectionFlag.TabIndex = 58
        Me.txt_ProtectionFlag.TabStop = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Protection (CRC):"
        '
        'txt_PrivateFlag
        '
        Me.txt_PrivateFlag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PrivateFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PrivateFlag.Location = New System.Drawing.Point(104, 168)
        Me.txt_PrivateFlag.Name = "txt_PrivateFlag"
        Me.txt_PrivateFlag.ReadOnly = True
        Me.txt_PrivateFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_PrivateFlag.TabIndex = 56
        Me.txt_PrivateFlag.TabStop = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Private:"
        '
        'txt_OriginalFlag
        '
        Me.txt_OriginalFlag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_OriginalFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_OriginalFlag.Location = New System.Drawing.Point(104, 152)
        Me.txt_OriginalFlag.Name = "txt_OriginalFlag"
        Me.txt_OriginalFlag.ReadOnly = True
        Me.txt_OriginalFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_OriginalFlag.TabIndex = 54
        Me.txt_OriginalFlag.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Original:"
        '
        'txt_CopyrightFlag
        '
        Me.txt_CopyrightFlag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_CopyrightFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_CopyrightFlag.Location = New System.Drawing.Point(104, 136)
        Me.txt_CopyrightFlag.Name = "txt_CopyrightFlag"
        Me.txt_CopyrightFlag.ReadOnly = True
        Me.txt_CopyrightFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_CopyrightFlag.TabIndex = 52
        Me.txt_CopyrightFlag.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Copyrighted:"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 104)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Mode:"
        '
        'txt_Level
        '
        Me.txt_Level.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Level.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Level.Location = New System.Drawing.Point(104, 24)
        Me.txt_Level.Name = "txt_Level"
        Me.txt_Level.ReadOnly = True
        Me.txt_Level.Size = New System.Drawing.Size(88, 13)
        Me.txt_Level.TabIndex = 34
        Me.txt_Level.TabStop = False
        '
        'txt_Frequency
        '
        Me.txt_Frequency.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Frequency.Location = New System.Drawing.Point(104, 72)
        Me.txt_Frequency.Name = "txt_Frequency"
        Me.txt_Frequency.ReadOnly = True
        Me.txt_Frequency.Size = New System.Drawing.Size(88, 13)
        Me.txt_Frequency.TabIndex = 37
        Me.txt_Frequency.TabStop = False
        '
        'txt_Size
        '
        Me.txt_Size.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Size.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Size.Location = New System.Drawing.Point(104, 120)
        Me.txt_Size.Name = "txt_Size"
        Me.txt_Size.ReadOnly = True
        Me.txt_Size.Size = New System.Drawing.Size(88, 13)
        Me.txt_Size.TabIndex = 40
        Me.txt_Size.TabStop = False
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Duration:"
        '
        'txt_Duration
        '
        Me.txt_Duration.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Duration.Location = New System.Drawing.Point(104, 88)
        Me.txt_Duration.Name = "txt_Duration"
        Me.txt_Duration.ReadOnly = True
        Me.txt_Duration.Size = New System.Drawing.Size(88, 13)
        Me.txt_Duration.TabIndex = 38
        Me.txt_Duration.TabStop = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Frequency:"
        '
        'txt_BitRate
        '
        Me.txt_BitRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_BitRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BitRate.Location = New System.Drawing.Point(104, 56)
        Me.txt_BitRate.Name = "txt_BitRate"
        Me.txt_BitRate.ReadOnly = True
        Me.txt_BitRate.Size = New System.Drawing.Size(88, 13)
        Me.txt_BitRate.TabIndex = 36
        Me.txt_BitRate.TabStop = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Level:"
        '
        'txt_Mode
        '
        Me.txt_Mode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Mode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Mode.Location = New System.Drawing.Point(104, 104)
        Me.txt_Mode.Name = "txt_Mode"
        Me.txt_Mode.ReadOnly = True
        Me.txt_Mode.Size = New System.Drawing.Size(88, 13)
        Me.txt_Mode.TabIndex = 39
        Me.txt_Mode.TabStop = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Bit Rate:"
        '
        'txt_Layer
        '
        Me.txt_Layer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Layer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Layer.Location = New System.Drawing.Point(104, 40)
        Me.txt_Layer.Name = "txt_Layer"
        Me.txt_Layer.ReadOnly = True
        Me.txt_Layer.Size = New System.Drawing.Size(88, 13)
        Me.txt_Layer.TabIndex = 35
        Me.txt_Layer.TabStop = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Layer:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Size:"
        '
        'cbxVBR
        '
        Me.cbxVBR.AutoSize = True
        Me.cbxVBR.Location = New System.Drawing.Point(146, 201)
        Me.cbxVBR.Name = "cbxVBR"
        Me.cbxVBR.Size = New System.Drawing.Size(48, 17)
        Me.cbxVBR.TabIndex = 60
        Me.cbxVBR.Text = "VBR"
        Me.cbxVBR.UseVisualStyleBackColor = True
        '
        'grp_ID3v2
        '
        Me.grp_ID3v2.Controls.Add(Me.chk_IsCoverV2)
        Me.grp_ID3v2.Controls.Add(Me.chk_IsRemixV2)
        Me.grp_ID3v2.Controls.Add(Me.Label13)
        Me.grp_ID3v2.Controls.Add(Me.txt_TrackCountV2)
        Me.grp_ID3v2.Controls.Add(Me.cmb_GenreV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_TrackNumV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_AlbumV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_CommentsV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_TitleV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_ArtistV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_YearV2)
        Me.grp_ID3v2.Enabled = False
        Me.grp_ID3v2.Location = New System.Drawing.Point(300, 36)
        Me.grp_ID3v2.Name = "grp_ID3v2"
        Me.grp_ID3v2.Size = New System.Drawing.Size(336, 232)
        Me.grp_ID3v2.TabIndex = 67
        Me.grp_ID3v2.TabStop = False
        Me.grp_ID3v2.Text = "ID3v2"
        '
        'chk_IsCoverV2
        '
        Me.chk_IsCoverV2.Location = New System.Drawing.Point(152, 144)
        Me.chk_IsCoverV2.Name = "chk_IsCoverV2"
        Me.chk_IsCoverV2.Size = New System.Drawing.Size(64, 16)
        Me.chk_IsCoverV2.TabIndex = 9
        Me.chk_IsCoverV2.Text = "Cover?"
        '
        'chk_IsRemixV2
        '
        Me.chk_IsRemixV2.Location = New System.Drawing.Point(232, 144)
        Me.chk_IsRemixV2.Name = "chk_IsRemixV2"
        Me.chk_IsRemixV2.Size = New System.Drawing.Size(64, 16)
        Me.chk_IsRemixV2.TabIndex = 8
        Me.chk_IsRemixV2.Text = "Remix?"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(64, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "of"
        '
        'txt_TrackCountV2
        '
        Me.txt_TrackCountV2.Location = New System.Drawing.Point(88, 72)
        Me.txt_TrackCountV2.Name = "txt_TrackCountV2"
        Me.txt_TrackCountV2.Size = New System.Drawing.Size(48, 20)
        Me.txt_TrackCountV2.TabIndex = 3
        '
        'cmb_GenreV2
        '
        Me.cmb_GenreV2.Location = New System.Drawing.Point(8, 144)
        Me.cmb_GenreV2.Name = "cmb_GenreV2"
        Me.cmb_GenreV2.Size = New System.Drawing.Size(128, 21)
        Me.cmb_GenreV2.TabIndex = 6
        '
        'txt_TrackNumV2
        '
        Me.txt_TrackNumV2.Location = New System.Drawing.Point(8, 72)
        Me.txt_TrackNumV2.Name = "txt_TrackNumV2"
        Me.txt_TrackNumV2.Size = New System.Drawing.Size(48, 20)
        Me.txt_TrackNumV2.TabIndex = 2
        '
        'txt_AlbumV2
        '
        Me.txt_AlbumV2.Location = New System.Drawing.Point(8, 96)
        Me.txt_AlbumV2.Name = "txt_AlbumV2"
        Me.txt_AlbumV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_AlbumV2.TabIndex = 4
        '
        'txt_CommentsV2
        '
        Me.txt_CommentsV2.Location = New System.Drawing.Point(8, 168)
        Me.txt_CommentsV2.Multiline = True
        Me.txt_CommentsV2.Name = "txt_CommentsV2"
        Me.txt_CommentsV2.Size = New System.Drawing.Size(320, 56)
        Me.txt_CommentsV2.TabIndex = 7
        '
        'txt_TitleV2
        '
        Me.txt_TitleV2.Location = New System.Drawing.Point(8, 48)
        Me.txt_TitleV2.Name = "txt_TitleV2"
        Me.txt_TitleV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_TitleV2.TabIndex = 1
        '
        'txt_ArtistV2
        '
        Me.txt_ArtistV2.Location = New System.Drawing.Point(8, 24)
        Me.txt_ArtistV2.Name = "txt_ArtistV2"
        Me.txt_ArtistV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_ArtistV2.TabIndex = 0
        '
        'txt_YearV2
        '
        Me.txt_YearV2.Location = New System.Drawing.Point(8, 120)
        Me.txt_YearV2.Name = "txt_YearV2"
        Me.txt_YearV2.Size = New System.Drawing.Size(100, 20)
        Me.txt_YearV2.TabIndex = 5
        '
        'grp_ID3v1
        '
        Me.grp_ID3v1.Controls.Add(Me.cmb_GenreV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_YearV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_AlbumV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_ArtistV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_CommentsV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_TrackNumV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_TitleV1)
        Me.grp_ID3v1.Enabled = False
        Me.grp_ID3v1.Location = New System.Drawing.Point(76, 36)
        Me.grp_ID3v1.Name = "grp_ID3v1"
        Me.grp_ID3v1.Size = New System.Drawing.Size(216, 232)
        Me.grp_ID3v1.TabIndex = 70
        Me.grp_ID3v1.TabStop = False
        Me.grp_ID3v1.Text = "ID3v1"
        '
        'cmb_GenreV1
        '
        Me.cmb_GenreV1.DisplayMember = "Name"
        Me.cmb_GenreV1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GenreV1.Location = New System.Drawing.Point(8, 144)
        Me.cmb_GenreV1.Name = "cmb_GenreV1"
        Me.cmb_GenreV1.Size = New System.Drawing.Size(128, 21)
        Me.cmb_GenreV1.TabIndex = 5
        Me.cmb_GenreV1.ValueMember = "Number"
        '
        'txt_YearV1
        '
        Me.txt_YearV1.Location = New System.Drawing.Point(8, 120)
        Me.txt_YearV1.MaxLength = 4
        Me.txt_YearV1.Name = "txt_YearV1"
        Me.txt_YearV1.Size = New System.Drawing.Size(100, 20)
        Me.txt_YearV1.TabIndex = 4
        '
        'txt_AlbumV1
        '
        Me.txt_AlbumV1.Location = New System.Drawing.Point(8, 96)
        Me.txt_AlbumV1.MaxLength = 30
        Me.txt_AlbumV1.Name = "txt_AlbumV1"
        Me.txt_AlbumV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_AlbumV1.TabIndex = 3
        '
        'txt_ArtistV1
        '
        Me.txt_ArtistV1.Location = New System.Drawing.Point(8, 24)
        Me.txt_ArtistV1.MaxLength = 30
        Me.txt_ArtistV1.Name = "txt_ArtistV1"
        Me.txt_ArtistV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_ArtistV1.TabIndex = 0
        '
        'txt_CommentsV1
        '
        Me.txt_CommentsV1.Location = New System.Drawing.Point(8, 168)
        Me.txt_CommentsV1.MaxLength = 30
        Me.txt_CommentsV1.Multiline = True
        Me.txt_CommentsV1.Name = "txt_CommentsV1"
        Me.txt_CommentsV1.Size = New System.Drawing.Size(200, 56)
        Me.txt_CommentsV1.TabIndex = 6
        '
        'txt_TrackNumV1
        '
        Me.txt_TrackNumV1.Location = New System.Drawing.Point(8, 72)
        Me.txt_TrackNumV1.MaxLength = 4
        Me.txt_TrackNumV1.Name = "txt_TrackNumV1"
        Me.txt_TrackNumV1.Size = New System.Drawing.Size(72, 20)
        Me.txt_TrackNumV1.TabIndex = 2
        '
        'txt_TitleV1
        '
        Me.txt_TitleV1.Location = New System.Drawing.Point(8, 48)
        Me.txt_TitleV1.MaxLength = 30
        Me.txt_TitleV1.Name = "txt_TitleV1"
        Me.txt_TitleV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_TitleV1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Comments:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Genre:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Track:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Artist:"
        '
        'chk_WriteID3v1Tag
        '
        Me.chk_WriteID3v1Tag.Location = New System.Drawing.Point(76, 12)
        Me.chk_WriteID3v1Tag.Name = "chk_WriteID3v1Tag"
        Me.chk_WriteID3v1Tag.Size = New System.Drawing.Size(80, 18)
        Me.chk_WriteID3v1Tag.TabIndex = 69
        Me.chk_WriteID3v1Tag.Text = "ID3v1 Tag"
        '
        'chk_WriteID3v2Tag
        '
        Me.chk_WriteID3v2Tag.Location = New System.Drawing.Point(300, 12)
        Me.chk_WriteID3v2Tag.Name = "chk_WriteID3v2Tag"
        Me.chk_WriteID3v2Tag.Size = New System.Drawing.Size(80, 18)
        Me.chk_WriteID3v2Tag.TabIndex = 68
        Me.chk_WriteID3v2Tag.Text = "ID3v2 Tag"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_AddPictures)
        Me.GroupBox2.Controls.Add(Me.btn_DeletePicture)
        Me.GroupBox2.Controls.Add(Me.pbx_Picture)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 243)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Album Art"
        '
        'frm_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 589)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_ID3v2)
        Me.Controls.Add(Me.grp_ID3v1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_WriteID3v1Tag)
        Me.Controls.Add(Me.chk_WriteID3v2Tag)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Write)
        Me.Controls.Add(Me.btn_Load)
        Me.MinimumSize = New System.Drawing.Size(680, 616)
        Me.Name = "frm_Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tag.NET"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cms_Frames.ResumeLayout(False)
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_ID3v2.ResumeLayout(False)
        Me.grp_ID3v2.PerformLayout()
        Me.grp_ID3v1.ResumeLayout(False)
        Me.grp_ID3v1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_Frames As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_DeletePicture As System.Windows.Forms.Button
    Friend WithEvents btn_AddPictures As System.Windows.Forms.Button
    Friend WithEvents pbx_Picture As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ProtectionFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_PrivateFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_OriginalFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_CopyrightFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_Level As System.Windows.Forms.TextBox
    Friend WithEvents txt_Frequency As System.Windows.Forms.TextBox
    Friend WithEvents txt_Size As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_Duration As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_BitRate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Mode As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Layer As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbxVBR As System.Windows.Forms.CheckBox
    Friend WithEvents grp_ID3v2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_IsCoverV2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_IsRemixV2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_TrackCountV2 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_GenreV2 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_TrackNumV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_AlbumV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CommentsV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TitleV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ArtistV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_YearV2 As System.Windows.Forms.TextBox
    Friend WithEvents grp_ID3v1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_GenreV1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_YearV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_AlbumV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ArtistV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CommentsV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TrackNumV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TitleV1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_WriteID3v1Tag As System.Windows.Forms.CheckBox
    Friend WithEvents chk_WriteID3v2Tag As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
