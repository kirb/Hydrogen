<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.ieBrowser = New System.Windows.Forms.WebBrowser()
        Me.tableMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tableToolbar = New System.Windows.Forms.TableLayoutPanel()
        Me.labelName = New System.Windows.Forms.Label()
        Me.textboxAddress = New System.Windows.Forms.TextBox()
        Me.panelStatus = New System.Windows.Forms.Panel()
        Me.progressStatus = New System.Windows.Forms.ProgressBar()
        Me.tableMain.SuspendLayout()
        Me.tableToolbar.SuspendLayout()
        Me.panelStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'ieBrowser
        '
        Me.ieBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ieBrowser.Location = New System.Drawing.Point(0, 26)
        Me.ieBrowser.Margin = New System.Windows.Forms.Padding(0)
        Me.ieBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ieBrowser.Name = "ieBrowser"
        Me.ieBrowser.Size = New System.Drawing.Size(886, 478)
        Me.ieBrowser.TabIndex = 1
        Me.ieBrowser.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'tableMain
        '
        Me.tableMain.ColumnCount = 1
        Me.tableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableMain.Controls.Add(Me.tableToolbar, 0, 0)
        Me.tableMain.Controls.Add(Me.ieBrowser, 0, 1)
        Me.tableMain.Controls.Add(Me.panelStatus, 0, 2)
        Me.tableMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableMain.Location = New System.Drawing.Point(0, 0)
        Me.tableMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tableMain.Name = "tableMain"
        Me.tableMain.RowCount = 3
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableMain.Size = New System.Drawing.Size(886, 524)
        Me.tableMain.TabIndex = 0
        '
        'tableToolbar
        '
        Me.tableToolbar.AutoSize = True
        Me.tableToolbar.ColumnCount = 3
        Me.tableMain.SetColumnSpan(Me.tableToolbar, 2)
        Me.tableToolbar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableToolbar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableToolbar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tableToolbar.Controls.Add(Me.labelName, 0, 0)
        Me.tableToolbar.Controls.Add(Me.textboxAddress, 1, 0)
        Me.tableToolbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableToolbar.Location = New System.Drawing.Point(0, 0)
        Me.tableToolbar.Margin = New System.Windows.Forms.Padding(0)
        Me.tableToolbar.Name = "tableToolbar"
        Me.tableToolbar.RowCount = 1
        Me.tableToolbar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableToolbar.Size = New System.Drawing.Size(886, 26)
        Me.tableToolbar.TabIndex = 3
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.BackColor = System.Drawing.Color.Transparent
        Me.labelName.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(3, 0)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(103, 25)
        Me.labelName.TabIndex = 3
        Me.labelName.Text = "Hydrogen"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelName.Visible = False
        '
        'textboxAddress
        '
        Me.textboxAddress.BackColor = System.Drawing.Color.White
        Me.textboxAddress.Dock = System.Windows.Forms.DockStyle.Top
        Me.textboxAddress.Location = New System.Drawing.Point(109, 0)
        Me.textboxAddress.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.textboxAddress.Name = "textboxAddress"
        Me.textboxAddress.Size = New System.Drawing.Size(667, 25)
        Me.textboxAddress.TabIndex = 2
        '
        'panelStatus
        '
        Me.panelStatus.Controls.Add(Me.progressStatus)
        Me.panelStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelStatus.Location = New System.Drawing.Point(0, 504)
        Me.panelStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.panelStatus.Name = "panelStatus"
        Me.panelStatus.Size = New System.Drawing.Size(886, 20)
        Me.panelStatus.TabIndex = 2
        '
        'progressStatus
        '
        Me.progressStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressStatus.Location = New System.Drawing.Point(0, 0)
        Me.progressStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.progressStatus.Name = "progressStatus"
        Me.progressStatus.Size = New System.Drawing.Size(886, 20)
        Me.progressStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progressStatus.TabIndex = 5
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 524)
        Me.Controls.Add(Me.tableMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formMain"
        Me.Text = "Hydrogen"
        Me.tableMain.ResumeLayout(False)
        Me.tableMain.PerformLayout()
        Me.tableToolbar.ResumeLayout(False)
        Me.tableToolbar.PerformLayout()
        Me.panelStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ieBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents panelStatus As System.Windows.Forms.Panel
    Friend WithEvents progressStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents tableToolbar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labelName As System.Windows.Forms.Label
    Friend WithEvents textboxAddress As System.Windows.Forms.TextBox

End Class
