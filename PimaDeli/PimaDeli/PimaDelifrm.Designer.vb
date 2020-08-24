<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PimaDelifrm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.gboxBread = New System.Windows.Forms.GroupBox()
        Me.rbtnItalian = New System.Windows.Forms.RadioButton()
        Me.rbtnWheat = New System.Windows.Forms.RadioButton()
        Me.rbtnWhite = New System.Windows.Forms.RadioButton()
        Me.gboxMeats = New System.Windows.Forms.GroupBox()
        Me.cboxRoastBeef = New System.Windows.Forms.CheckBox()
        Me.cboxTurkey = New System.Windows.Forms.CheckBox()
        Me.cboxHam = New System.Windows.Forms.CheckBox()
        Me.gboxCheeses = New System.Windows.Forms.GroupBox()
        Me.cboxNoCheese = New System.Windows.Forms.CheckBox()
        Me.cboxPepperJack = New System.Windows.Forms.CheckBox()
        Me.cboxCheddar = New System.Windows.Forms.CheckBox()
        Me.cboxSwiss = New System.Windows.Forms.CheckBox()
        Me.gboxCondiments = New System.Windows.Forms.GroupBox()
        Me.cboxNoCondiments = New System.Windows.Forms.CheckBox()
        Me.cboxJalapeno = New System.Windows.Forms.CheckBox()
        Me.cboxOnion = New System.Windows.Forms.CheckBox()
        Me.cboxPickle = New System.Windows.Forms.CheckBox()
        Me.cboxTomato = New System.Windows.Forms.CheckBox()
        Me.cboxLettuce = New System.Windows.Forms.CheckBox()
        Me.cboxPepper = New System.Windows.Forms.CheckBox()
        Me.cboxSalt = New System.Windows.Forms.CheckBox()
        Me.cboxKetchup = New System.Windows.Forms.CheckBox()
        Me.cboxMayo = New System.Windows.Forms.CheckBox()
        Me.cboxMustard = New System.Windows.Forms.CheckBox()
        Me.gboxDrinks = New System.Windows.Forms.GroupBox()
        Me.rbtnNoDrink = New System.Windows.Forms.RadioButton()
        Me.rbtnApple = New System.Windows.Forms.RadioButton()
        Me.rbtnFountain = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.gboxBread.SuspendLayout()
        Me.gboxMeats.SuspendLayout()
        Me.gboxCheeses.SuspendLayout()
        Me.gboxCondiments.SuspendLayout()
        Me.gboxDrinks.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PricesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(227, 31)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(87, 59)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Menu"
        '
        'gboxBread
        '
        Me.gboxBread.Controls.Add(Me.rbtnItalian)
        Me.gboxBread.Controls.Add(Me.rbtnWheat)
        Me.gboxBread.Controls.Add(Me.rbtnWhite)
        Me.gboxBread.Location = New System.Drawing.Point(51, 93)
        Me.gboxBread.Name = "gboxBread"
        Me.gboxBread.Size = New System.Drawing.Size(200, 100)
        Me.gboxBread.TabIndex = 2
        Me.gboxBread.TabStop = False
        Me.gboxBread.Text = "Select Your Bread"
        '
        'rbtnItalian
        '
        Me.rbtnItalian.AutoSize = True
        Me.rbtnItalian.Location = New System.Drawing.Point(7, 68)
        Me.rbtnItalian.Name = "rbtnItalian"
        Me.rbtnItalian.Size = New System.Drawing.Size(53, 17)
        Me.rbtnItalian.TabIndex = 2
        Me.rbtnItalian.TabStop = True
        Me.rbtnItalian.Text = "Italian"
        Me.rbtnItalian.UseVisualStyleBackColor = True
        '
        'rbtnWheat
        '
        Me.rbtnWheat.AutoSize = True
        Me.rbtnWheat.Location = New System.Drawing.Point(7, 44)
        Me.rbtnWheat.Name = "rbtnWheat"
        Me.rbtnWheat.Size = New System.Drawing.Size(91, 17)
        Me.rbtnWheat.TabIndex = 1
        Me.rbtnWheat.TabStop = True
        Me.rbtnWheat.Text = "Whole Wheat"
        Me.rbtnWheat.UseVisualStyleBackColor = True
        '
        'rbtnWhite
        '
        Me.rbtnWhite.AutoSize = True
        Me.rbtnWhite.Checked = True
        Me.rbtnWhite.Location = New System.Drawing.Point(7, 20)
        Me.rbtnWhite.Name = "rbtnWhite"
        Me.rbtnWhite.Size = New System.Drawing.Size(53, 17)
        Me.rbtnWhite.TabIndex = 0
        Me.rbtnWhite.TabStop = True
        Me.rbtnWhite.Text = "White"
        Me.rbtnWhite.UseVisualStyleBackColor = True
        '
        'gboxMeats
        '
        Me.gboxMeats.Controls.Add(Me.cboxRoastBeef)
        Me.gboxMeats.Controls.Add(Me.cboxTurkey)
        Me.gboxMeats.Controls.Add(Me.cboxHam)
        Me.gboxMeats.Location = New System.Drawing.Point(58, 242)
        Me.gboxMeats.Name = "gboxMeats"
        Me.gboxMeats.Size = New System.Drawing.Size(200, 100)
        Me.gboxMeats.TabIndex = 3
        Me.gboxMeats.TabStop = False
        Me.gboxMeats.Text = "Select Your Meat"
        '
        'cboxRoastBeef
        '
        Me.cboxRoastBeef.AutoSize = True
        Me.cboxRoastBeef.Location = New System.Drawing.Point(7, 67)
        Me.cboxRoastBeef.Name = "cboxRoastBeef"
        Me.cboxRoastBeef.Size = New System.Drawing.Size(79, 17)
        Me.cboxRoastBeef.TabIndex = 2
        Me.cboxRoastBeef.Text = "Roast Beef"
        Me.cboxRoastBeef.UseVisualStyleBackColor = True
        '
        'cboxTurkey
        '
        Me.cboxTurkey.AutoSize = True
        Me.cboxTurkey.Location = New System.Drawing.Point(7, 44)
        Me.cboxTurkey.Name = "cboxTurkey"
        Me.cboxTurkey.Size = New System.Drawing.Size(59, 17)
        Me.cboxTurkey.TabIndex = 1
        Me.cboxTurkey.Text = "Turkey"
        Me.cboxTurkey.UseVisualStyleBackColor = True
        '
        'cboxHam
        '
        Me.cboxHam.AutoSize = True
        Me.cboxHam.Location = New System.Drawing.Point(7, 20)
        Me.cboxHam.Name = "cboxHam"
        Me.cboxHam.Size = New System.Drawing.Size(48, 17)
        Me.cboxHam.TabIndex = 0
        Me.cboxHam.Text = "Ham"
        Me.cboxHam.UseVisualStyleBackColor = True
        '
        'gboxCheeses
        '
        Me.gboxCheeses.Controls.Add(Me.cboxNoCheese)
        Me.gboxCheeses.Controls.Add(Me.cboxPepperJack)
        Me.gboxCheeses.Controls.Add(Me.cboxCheddar)
        Me.gboxCheeses.Controls.Add(Me.cboxSwiss)
        Me.gboxCheeses.Location = New System.Drawing.Point(58, 402)
        Me.gboxCheeses.Name = "gboxCheeses"
        Me.gboxCheeses.Size = New System.Drawing.Size(200, 115)
        Me.gboxCheeses.TabIndex = 4
        Me.gboxCheeses.TabStop = False
        Me.gboxCheeses.Text = "Select Your Choice of Cheese"
        '
        'cboxNoCheese
        '
        Me.cboxNoCheese.AutoSize = True
        Me.cboxNoCheese.Location = New System.Drawing.Point(7, 92)
        Me.cboxNoCheese.Name = "cboxNoCheese"
        Me.cboxNoCheese.Size = New System.Drawing.Size(52, 17)
        Me.cboxNoCheese.TabIndex = 3
        Me.cboxNoCheese.Text = "None"
        Me.cboxNoCheese.UseVisualStyleBackColor = True
        '
        'cboxPepperJack
        '
        Me.cboxPepperJack.AutoSize = True
        Me.cboxPepperJack.Location = New System.Drawing.Point(7, 68)
        Me.cboxPepperJack.Name = "cboxPepperJack"
        Me.cboxPepperJack.Size = New System.Drawing.Size(86, 17)
        Me.cboxPepperJack.TabIndex = 2
        Me.cboxPepperJack.Text = "Pepper Jack"
        Me.cboxPepperJack.UseVisualStyleBackColor = True
        '
        'cboxCheddar
        '
        Me.cboxCheddar.AutoSize = True
        Me.cboxCheddar.Location = New System.Drawing.Point(7, 44)
        Me.cboxCheddar.Name = "cboxCheddar"
        Me.cboxCheddar.Size = New System.Drawing.Size(66, 17)
        Me.cboxCheddar.TabIndex = 1
        Me.cboxCheddar.Text = "Cheddar"
        Me.cboxCheddar.UseVisualStyleBackColor = True
        '
        'cboxSwiss
        '
        Me.cboxSwiss.AutoSize = True
        Me.cboxSwiss.Location = New System.Drawing.Point(7, 20)
        Me.cboxSwiss.Name = "cboxSwiss"
        Me.cboxSwiss.Size = New System.Drawing.Size(53, 17)
        Me.cboxSwiss.TabIndex = 0
        Me.cboxSwiss.Text = "Swiss"
        Me.cboxSwiss.UseVisualStyleBackColor = True
        '
        'gboxCondiments
        '
        Me.gboxCondiments.Controls.Add(Me.cboxNoCondiments)
        Me.gboxCondiments.Controls.Add(Me.cboxJalapeno)
        Me.gboxCondiments.Controls.Add(Me.cboxOnion)
        Me.gboxCondiments.Controls.Add(Me.cboxPickle)
        Me.gboxCondiments.Controls.Add(Me.cboxTomato)
        Me.gboxCondiments.Controls.Add(Me.cboxLettuce)
        Me.gboxCondiments.Controls.Add(Me.cboxPepper)
        Me.gboxCondiments.Controls.Add(Me.cboxSalt)
        Me.gboxCondiments.Controls.Add(Me.cboxKetchup)
        Me.gboxCondiments.Controls.Add(Me.cboxMayo)
        Me.gboxCondiments.Controls.Add(Me.cboxMustard)
        Me.gboxCondiments.Location = New System.Drawing.Point(317, 93)
        Me.gboxCondiments.Name = "gboxCondiments"
        Me.gboxCondiments.Size = New System.Drawing.Size(200, 278)
        Me.gboxCondiments.TabIndex = 5
        Me.gboxCondiments.TabStop = False
        Me.gboxCondiments.Text = "Choose Your Condiments"
        '
        'cboxNoCondiments
        '
        Me.cboxNoCondiments.AutoSize = True
        Me.cboxNoCondiments.Location = New System.Drawing.Point(7, 255)
        Me.cboxNoCondiments.Name = "cboxNoCondiments"
        Me.cboxNoCondiments.Size = New System.Drawing.Size(52, 17)
        Me.cboxNoCondiments.TabIndex = 10
        Me.cboxNoCondiments.Text = "None"
        Me.cboxNoCondiments.UseVisualStyleBackColor = True
        '
        'cboxJalapeno
        '
        Me.cboxJalapeno.AutoSize = True
        Me.cboxJalapeno.Location = New System.Drawing.Point(7, 231)
        Me.cboxJalapeno.Name = "cboxJalapeno"
        Me.cboxJalapeno.Size = New System.Drawing.Size(74, 17)
        Me.cboxJalapeno.TabIndex = 9
        Me.cboxJalapeno.Text = "Jalapenos"
        Me.cboxJalapeno.UseVisualStyleBackColor = True
        '
        'cboxOnion
        '
        Me.cboxOnion.AutoSize = True
        Me.cboxOnion.Location = New System.Drawing.Point(7, 208)
        Me.cboxOnion.Name = "cboxOnion"
        Me.cboxOnion.Size = New System.Drawing.Size(54, 17)
        Me.cboxOnion.TabIndex = 8
        Me.cboxOnion.Text = "Onion"
        Me.cboxOnion.UseVisualStyleBackColor = True
        '
        'cboxPickle
        '
        Me.cboxPickle.AutoSize = True
        Me.cboxPickle.Location = New System.Drawing.Point(7, 187)
        Me.cboxPickle.Name = "cboxPickle"
        Me.cboxPickle.Size = New System.Drawing.Size(55, 17)
        Me.cboxPickle.TabIndex = 7
        Me.cboxPickle.Text = "Pickle"
        Me.cboxPickle.UseVisualStyleBackColor = True
        '
        'cboxTomato
        '
        Me.cboxTomato.AutoSize = True
        Me.cboxTomato.Location = New System.Drawing.Point(7, 163)
        Me.cboxTomato.Name = "cboxTomato"
        Me.cboxTomato.Size = New System.Drawing.Size(62, 17)
        Me.cboxTomato.TabIndex = 6
        Me.cboxTomato.Text = "Tomato"
        Me.cboxTomato.UseVisualStyleBackColor = True
        '
        'cboxLettuce
        '
        Me.cboxLettuce.AutoSize = True
        Me.cboxLettuce.Location = New System.Drawing.Point(7, 139)
        Me.cboxLettuce.Name = "cboxLettuce"
        Me.cboxLettuce.Size = New System.Drawing.Size(62, 17)
        Me.cboxLettuce.TabIndex = 5
        Me.cboxLettuce.Text = "Lettuce"
        Me.cboxLettuce.UseVisualStyleBackColor = True
        '
        'cboxPepper
        '
        Me.cboxPepper.AutoSize = True
        Me.cboxPepper.Location = New System.Drawing.Point(7, 116)
        Me.cboxPepper.Name = "cboxPepper"
        Me.cboxPepper.Size = New System.Drawing.Size(60, 17)
        Me.cboxPepper.TabIndex = 4
        Me.cboxPepper.Text = "Pepper"
        Me.cboxPepper.UseVisualStyleBackColor = True
        '
        'cboxSalt
        '
        Me.cboxSalt.AutoSize = True
        Me.cboxSalt.Location = New System.Drawing.Point(7, 93)
        Me.cboxSalt.Name = "cboxSalt"
        Me.cboxSalt.Size = New System.Drawing.Size(44, 17)
        Me.cboxSalt.TabIndex = 3
        Me.cboxSalt.Text = "Salt"
        Me.cboxSalt.UseVisualStyleBackColor = True
        '
        'cboxKetchup
        '
        Me.cboxKetchup.AutoSize = True
        Me.cboxKetchup.Location = New System.Drawing.Point(7, 68)
        Me.cboxKetchup.Name = "cboxKetchup"
        Me.cboxKetchup.Size = New System.Drawing.Size(66, 17)
        Me.cboxKetchup.TabIndex = 2
        Me.cboxKetchup.Text = "Ketchup"
        Me.cboxKetchup.UseVisualStyleBackColor = True
        '
        'cboxMayo
        '
        Me.cboxMayo.AutoSize = True
        Me.cboxMayo.Location = New System.Drawing.Point(7, 44)
        Me.cboxMayo.Name = "cboxMayo"
        Me.cboxMayo.Size = New System.Drawing.Size(52, 17)
        Me.cboxMayo.TabIndex = 1
        Me.cboxMayo.Text = "Mayo"
        Me.cboxMayo.UseVisualStyleBackColor = True
        '
        'cboxMustard
        '
        Me.cboxMustard.AutoSize = True
        Me.cboxMustard.Location = New System.Drawing.Point(7, 20)
        Me.cboxMustard.Name = "cboxMustard"
        Me.cboxMustard.Size = New System.Drawing.Size(64, 17)
        Me.cboxMustard.TabIndex = 0
        Me.cboxMustard.Text = "Mustard"
        Me.cboxMustard.UseVisualStyleBackColor = True
        '
        'gboxDrinks
        '
        Me.gboxDrinks.Controls.Add(Me.rbtnNoDrink)
        Me.gboxDrinks.Controls.Add(Me.rbtnApple)
        Me.gboxDrinks.Controls.Add(Me.rbtnFountain)
        Me.gboxDrinks.Location = New System.Drawing.Point(317, 402)
        Me.gboxDrinks.Name = "gboxDrinks"
        Me.gboxDrinks.Size = New System.Drawing.Size(193, 109)
        Me.gboxDrinks.TabIndex = 6
        Me.gboxDrinks.TabStop = False
        Me.gboxDrinks.Text = "Choose a Drink"
        '
        'rbtnNoDrink
        '
        Me.rbtnNoDrink.AutoSize = True
        Me.rbtnNoDrink.Checked = True
        Me.rbtnNoDrink.Location = New System.Drawing.Point(7, 68)
        Me.rbtnNoDrink.Name = "rbtnNoDrink"
        Me.rbtnNoDrink.Size = New System.Drawing.Size(51, 17)
        Me.rbtnNoDrink.TabIndex = 2
        Me.rbtnNoDrink.TabStop = True
        Me.rbtnNoDrink.Text = "None"
        Me.rbtnNoDrink.UseVisualStyleBackColor = True
        '
        'rbtnApple
        '
        Me.rbtnApple.AutoSize = True
        Me.rbtnApple.Location = New System.Drawing.Point(7, 44)
        Me.rbtnApple.Name = "rbtnApple"
        Me.rbtnApple.Size = New System.Drawing.Size(80, 17)
        Me.rbtnApple.TabIndex = 1
        Me.rbtnApple.TabStop = True
        Me.rbtnApple.Text = "Apple Juice"
        Me.rbtnApple.UseVisualStyleBackColor = True
        '
        'rbtnFountain
        '
        Me.rbtnFountain.AutoSize = True
        Me.rbtnFountain.Location = New System.Drawing.Point(7, 20)
        Me.rbtnFountain.Name = "rbtnFountain"
        Me.rbtnFountain.Size = New System.Drawing.Size(94, 17)
        Me.rbtnFountain.TabIndex = 0
        Me.rbtnFountain.TabStop = True
        Me.rbtnFountain.Text = "Fountain Drink"
        Me.rbtnFountain.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(580, 470)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "P&review"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(707, 470)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PimaDeli.My.Resources.Resources.pima_cc_logo
        Me.PictureBox1.Location = New System.Drawing.Point(560, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 199)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PricesToolStripMenuItem
        '
        Me.PricesToolStripMenuItem.Name = "PricesToolStripMenuItem"
        Me.PricesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PricesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PricesToolStripMenuItem.Text = "&Prices"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PimaDelifrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.gboxDrinks)
        Me.Controls.Add(Me.gboxCondiments)
        Me.Controls.Add(Me.gboxCheeses)
        Me.Controls.Add(Me.gboxMeats)
        Me.Controls.Add(Me.gboxBread)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PimaDelifrm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gboxBread.ResumeLayout(False)
        Me.gboxBread.PerformLayout()
        Me.gboxMeats.ResumeLayout(False)
        Me.gboxMeats.PerformLayout()
        Me.gboxCheeses.ResumeLayout(False)
        Me.gboxCheeses.PerformLayout()
        Me.gboxCondiments.ResumeLayout(False)
        Me.gboxCondiments.PerformLayout()
        Me.gboxDrinks.ResumeLayout(False)
        Me.gboxDrinks.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblMenu As Label
    Friend WithEvents gboxBread As GroupBox
    Friend WithEvents rbtnItalian As RadioButton
    Friend WithEvents rbtnWheat As RadioButton
    Friend WithEvents rbtnWhite As RadioButton
    Friend WithEvents gboxMeats As GroupBox
    Friend WithEvents gboxCheeses As GroupBox
    Friend WithEvents cboxRoastBeef As CheckBox
    Friend WithEvents cboxTurkey As CheckBox
    Friend WithEvents cboxHam As CheckBox
    Friend WithEvents cboxNoCheese As CheckBox
    Friend WithEvents cboxPepperJack As CheckBox
    Friend WithEvents cboxCheddar As CheckBox
    Friend WithEvents cboxSwiss As CheckBox
    Friend WithEvents gboxCondiments As GroupBox
    Friend WithEvents cboxNoCondiments As CheckBox
    Friend WithEvents cboxJalapeno As CheckBox
    Friend WithEvents cboxOnion As CheckBox
    Friend WithEvents cboxPickle As CheckBox
    Friend WithEvents cboxTomato As CheckBox
    Friend WithEvents cboxLettuce As CheckBox
    Friend WithEvents cboxPepper As CheckBox
    Friend WithEvents cboxSalt As CheckBox
    Friend WithEvents cboxKetchup As CheckBox
    Friend WithEvents cboxMayo As CheckBox
    Friend WithEvents cboxMustard As CheckBox
    Friend WithEvents gboxDrinks As GroupBox
    Friend WithEvents rbtnNoDrink As RadioButton
    Friend WithEvents rbtnApple As RadioButton
    Friend WithEvents rbtnFountain As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PricesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
