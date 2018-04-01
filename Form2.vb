Public Class Form2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

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
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.pbIcon = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'lblCopyright
        '
        Me.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCopyright.Location = New System.Drawing.Point(24, 72)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(160, 16)
        Me.lblCopyright.TabIndex = 12
        Me.lblCopyright.Text = "Application Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(120, 128)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        '
        'lblVersion
        '
        Me.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVersion.Location = New System.Drawing.Point(24, 48)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(160, 16)
        Me.lblVersion.TabIndex = 9
        Me.lblVersion.Text = "Application Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(24, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(160, 16)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Application Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbIcon
        '
        Me.pbIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbIcon.Location = New System.Drawing.Point(16, 16)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(32, 32)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIcon.TabIndex = 7
        Me.pbIcon.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 96)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(160, 16)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "waynelloyd@btopenworld.com"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 160)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVersion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About...."
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("mailto:waynelloyd@btopenworld.com")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Set this Form's Text & Icon properties by using values from the parent form
            Me.Text = "About " & Me.Owner.Text
            Me.Icon = Me.Owner.Icon

            ' Set this Form's Picture Box's image using the parent's icon 
            ' However, we need to convert it to a Bitmap since the Picture Box Control
            ' will not accept a raw Icon.
            Me.pbIcon.Image = Me.Owner.Icon.ToBitmap()

            ' Set the labels identitying the Title, Version, and Description by
            ' reading Assembly meta-data originally entered in the AssemblyInfo.vb file
            ' using the AssemblyInfo class defined in the same file
            Dim ainfo As New AssemblyInfo

            Me.lblTitle.Text = ainfo.Title
            Me.lblVersion.Text = String.Format("Version {0}", ainfo.Version)
            Me.lblCopyright.Text = ainfo.Copyright

        Catch exp As System.Exception
            ' This catch will trap any unexpected error.
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub
End Class
