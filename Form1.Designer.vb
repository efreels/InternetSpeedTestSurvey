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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(307, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(416, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterSpeed.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSpeed.Location = New System.Drawing.Point(372, 92)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(250, 45)
        Me.btnEnterSpeed.TabIndex = 1
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeeds
        '
        Me.lstSpeeds.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 23
        Me.lstSpeeds.Location = New System.Drawing.Point(734, 92)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(90, 165)
        Me.lstSpeeds.TabIndex = 2
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(464, 427)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(211, 19)
        Me.lblAvg.TabIndex = 3
        Me.lblAvg.Text = "Average Internet Speed:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(742, 263)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InternetSpeedTestSurvey.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 523)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents lblAvg As Label
    Friend WithEvents btnClear As Button
End Class
