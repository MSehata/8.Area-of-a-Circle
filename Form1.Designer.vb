<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAnswer = New Button()
        txtRadius = New TextBox()
        txtAnswer = New TextBox()
        lblRadius = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnAnswer
        ' 
        btnAnswer.Location = New Point(243, 184)
        btnAnswer.Name = "btnAnswer"
        btnAnswer.Size = New Size(94, 29)
        btnAnswer.TabIndex = 1
        btnAnswer.Text = "Answer"
        btnAnswer.UseVisualStyleBackColor = True
        ' 
        ' txtRadius
        ' 
        txtRadius.Location = New Point(441, 115)
        txtRadius.Name = "txtRadius"
        txtRadius.Size = New Size(125, 27)
        txtRadius.TabIndex = 2
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(441, 184)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(125, 27)
        txtAnswer.TabIndex = 3
        ' 
        ' lblRadius
        ' 
        lblRadius.AutoSize = True
        lblRadius.Location = New Point(243, 118)
        lblRadius.Name = "lblRadius"
        lblRadius.Size = New Size(53, 20)
        lblRadius.TabIndex = 4
        lblRadius.Text = "Radius"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(379, 305)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 5
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(lblRadius)
        Controls.Add(txtAnswer)
        Controls.Add(txtRadius)
        Controls.Add(btnAnswer)
        Name = "Form1"
        Text = "Area of a Circle"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnAnswer As Button
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblRadius As Label
    Friend WithEvents btnClose As Button
End Class
