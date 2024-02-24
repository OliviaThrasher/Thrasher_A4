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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelFarmB = New Label()
        PicMeat = New PictureBox()
        ButtonSelect = New Button()
        PicVeggie = New PictureBox()
        ButtonMeat = New Button()
        ButtonVeggie = New Button()
        TextInstructions = New TextBox()
        ButtonExit = New Button()
        TextConfirm = New TextBox()
        CType(PicMeat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicVeggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelFarmB
        ' 
        LabelFarmB.AutoSize = True
        LabelFarmB.Font = New Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelFarmB.Location = New Point(229, 9)
        LabelFarmB.Name = "LabelFarmB"
        LabelFarmB.Size = New Size(327, 32)
        LabelFarmB.TabIndex = 0
        LabelFarmB.Text = "Farm Burger Specials"
        ' 
        ' PicMeat
        ' 
        PicMeat.BackgroundImage = CType(resources.GetObject("PicMeat.BackgroundImage"), Image)
        PicMeat.BackgroundImageLayout = ImageLayout.Stretch
        PicMeat.Location = New Point(127, 67)
        PicMeat.Name = "PicMeat"
        PicMeat.Size = New Size(233, 184)
        PicMeat.TabIndex = 1
        PicMeat.TabStop = False
        PicMeat.Visible = False
        ' 
        ' ButtonSelect
        ' 
        ButtonSelect.Enabled = False
        ButtonSelect.Location = New Point(336, 300)
        ButtonSelect.Name = "ButtonSelect"
        ButtonSelect.Size = New Size(112, 34)
        ButtonSelect.TabIndex = 2
        ButtonSelect.Text = "Select"
        ButtonSelect.UseVisualStyleBackColor = True
        ' 
        ' PicVeggie
        ' 
        PicVeggie.BackgroundImage = CType(resources.GetObject("PicVeggie.BackgroundImage"), Image)
        PicVeggie.BackgroundImageLayout = ImageLayout.Stretch
        PicVeggie.Location = New Point(419, 67)
        PicVeggie.Name = "PicVeggie"
        PicVeggie.Size = New Size(233, 184)
        PicVeggie.TabIndex = 3
        PicVeggie.TabStop = False
        PicVeggie.Visible = False
        ' 
        ' ButtonMeat
        ' 
        ButtonMeat.Location = New Point(127, 300)
        ButtonMeat.Name = "ButtonMeat"
        ButtonMeat.Size = New Size(112, 34)
        ButtonMeat.TabIndex = 4
        ButtonMeat.Text = "Prime Beef"
        ButtonMeat.UseVisualStyleBackColor = True
        ' 
        ' ButtonVeggie
        ' 
        ButtonVeggie.Location = New Point(540, 300)
        ButtonVeggie.Name = "ButtonVeggie"
        ButtonVeggie.Size = New Size(112, 34)
        ButtonVeggie.TabIndex = 5
        ButtonVeggie.Text = "Veggie"
        ButtonVeggie.UseVisualStyleBackColor = True
        ' 
        ' TextInstructions
        ' 
        TextInstructions.BackColor = SystemColors.Menu
        TextInstructions.BorderStyle = BorderStyle.None
        TextInstructions.Location = New Point(203, 340)
        TextInstructions.Name = "TextInstructions"
        TextInstructions.Size = New Size(378, 24)
        TextInstructions.TabIndex = 6
        TextInstructions.Text = "Choose a burger then click the Select button."
        TextInstructions.TextAlign = HorizontalAlignment.Center
        ' 
        ' ButtonExit
        ' 
        ButtonExit.Location = New Point(336, 404)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(112, 34)
        ButtonExit.TabIndex = 7
        ButtonExit.Text = "Exit"
        ButtonExit.UseVisualStyleBackColor = True
        ' 
        ' TextConfirm
        ' 
        TextConfirm.BackColor = SystemColors.Menu
        TextConfirm.BorderStyle = BorderStyle.None
        TextConfirm.Location = New Point(203, 370)
        TextConfirm.Name = "TextConfirm"
        TextConfirm.Size = New Size(378, 24)
        TextConfirm.TabIndex = 8
        TextConfirm.Text = "Enjoy your burger special!"
        TextConfirm.TextAlign = HorizontalAlignment.Center
        TextConfirm.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextConfirm)
        Controls.Add(ButtonExit)
        Controls.Add(TextInstructions)
        Controls.Add(ButtonVeggie)
        Controls.Add(ButtonMeat)
        Controls.Add(PicVeggie)
        Controls.Add(ButtonSelect)
        Controls.Add(PicMeat)
        Controls.Add(LabelFarmB)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Burger Specials"
        CType(PicMeat, ComponentModel.ISupportInitialize).EndInit()
        CType(PicVeggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelFarmB As Label
    Friend WithEvents PicMeat As PictureBox
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents PicVeggie As PictureBox
    Friend WithEvents ButtonMeat As Button
    Friend WithEvents ButtonVeggie As Button
    Friend WithEvents TextInstructions As TextBox
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TextConfirm As TextBox

End Class
