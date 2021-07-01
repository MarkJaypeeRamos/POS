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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsPOS = New System.Windows.Forms.ToolStripButton()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.tsItems = New System.Windows.Forms.ToolStripButton()
        Me.tsStocks = New System.Windows.Forms.ToolStripButton()
        Me.tsManage = New System.Windows.Forms.ToolStripButton()
        Me.tsReport = New System.Windows.Forms.ToolStripButton()
        Me.tsHelp = New System.Windows.Forms.ToolStripButton()
        Me.tsExit = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.companyName1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPOS, Me.tsLogin, Me.tsItems, Me.tsStocks, Me.tsManage, Me.tsReport, Me.tsHelp, Me.tsExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(7, 4, 5, 5)
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 61)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsPOS
        '
        Me.tsPOS.AutoSize = False
        Me.tsPOS.Image = CType(resources.GetObject("tsPOS.Image"), System.Drawing.Image)
        Me.tsPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPOS.Margin = New System.Windows.Forms.Padding(1, 1, 0, 2)
        Me.tsPOS.Name = "tsPOS"
        Me.tsPOS.Size = New System.Drawing.Size(95, 50)
        Me.tsPOS.Text = "POS"
        Me.tsPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsLogin
        '
        Me.tsLogin.AutoSize = False
        Me.tsLogin.Image = CType(resources.GetObject("tsLogin.Image"), System.Drawing.Image)
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(95, 50)
        Me.tsLogin.Text = "Login"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsItems
        '
        Me.tsItems.AutoSize = False
        Me.tsItems.Image = CType(resources.GetObject("tsItems.Image"), System.Drawing.Image)
        Me.tsItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsItems.Name = "tsItems"
        Me.tsItems.Size = New System.Drawing.Size(95, 50)
        Me.tsItems.Text = "Items"
        Me.tsItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsStocks
        '
        Me.tsStocks.AutoSize = False
        Me.tsStocks.Image = CType(resources.GetObject("tsStocks.Image"), System.Drawing.Image)
        Me.tsStocks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsStocks.Name = "tsStocks"
        Me.tsStocks.Size = New System.Drawing.Size(97, 50)
        Me.tsStocks.Text = "Stocks"
        Me.tsStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsManage
        '
        Me.tsManage.AutoSize = False
        Me.tsManage.Image = CType(resources.GetObject("tsManage.Image"), System.Drawing.Image)
        Me.tsManage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsManage.Name = "tsManage"
        Me.tsManage.Size = New System.Drawing.Size(97, 50)
        Me.tsManage.Text = "Manage"
        Me.tsManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsReport
        '
        Me.tsReport.AutoSize = False
        Me.tsReport.Image = CType(resources.GetObject("tsReport.Image"), System.Drawing.Image)
        Me.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReport.Name = "tsReport"
        Me.tsReport.Size = New System.Drawing.Size(97, 50)
        Me.tsReport.Text = "Reports"
        Me.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsHelp
        '
        Me.tsHelp.AutoSize = False
        Me.tsHelp.Image = CType(resources.GetObject("tsHelp.Image"), System.Drawing.Image)
        Me.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHelp.Name = "tsHelp"
        Me.tsHelp.Size = New System.Drawing.Size(97, 50)
        Me.tsHelp.Text = "Help"
        Me.tsHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsExit
        '
        Me.tsExit.AutoSize = False
        Me.tsExit.Image = CType(resources.GetObject("tsExit.Image"), System.Drawing.Image)
        Me.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(97, 50)
        Me.tsExit.Text = "Exit"
        Me.tsExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.companyName1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 69)
        Me.Panel1.TabIndex = 3
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(597, 43)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(121, 15)
        Me.user.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(600, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(197, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales and Inventory System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'companyName1
        '
        Me.companyName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyName1.Location = New System.Drawing.Point(243, 8)
        Me.companyName1.Name = "companyName1"
        Me.companyName1.Size = New System.Drawing.Size(312, 32)
        Me.companyName1.TabIndex = 0
        Me.companyName1.Text = "Laci Trading and Services"
        Me.companyName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsPOS As ToolStripButton
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents tsExit As ToolStripButton
    Friend WithEvents tsItems As ToolStripButton
    Friend WithEvents tsStocks As ToolStripButton
    Friend WithEvents tsManage As ToolStripButton
    Friend WithEvents tsReport As ToolStripButton
    Friend WithEvents tsHelp As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents companyName1 As Label
    Friend WithEvents user As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
