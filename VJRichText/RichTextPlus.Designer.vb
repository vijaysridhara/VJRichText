Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RichTextPlus
    Inherits System.Windows.Forms.UserControl


    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RichTextPlus))
        Me.butBackColor = New System.Windows.Forms.ToolStripDropDownButton()
        Me.butForeColor = New System.Windows.Forms.ToolStripDropDownButton()
        Me.butUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpRich = New System.Windows.Forms.ToolStrip()
        Me.butFind = New System.Windows.Forms.ToolStripButton()
        Me.butFindReplace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.butRedo = New System.Windows.Forms.ToolStripButton()
        Me.butBold = New System.Windows.Forms.ToolStripButton()
        Me.butItalic = New System.Windows.Forms.ToolStripButton()
        Me.butUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.butBullets = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.butShowinRichEditor = New System.Windows.Forms.ToolStripButton()
        Me.cboFonts = New System.Windows.Forms.ToolStripComboBox()
        Me.cboSize = New System.Windows.Forms.ToolStripComboBox()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxRich = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ra = New System.Windows.Forms.RichTextBox()
        Me.tlstpRich.SuspendLayout()
        Me.ctxRich.SuspendLayout()
        Me.SuspendLayout()
        '
        'butBackColor
        '
        Me.butBackColor.BackColor = System.Drawing.Color.Red
        Me.butBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.butBackColor.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butBackColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butBackColor.Name = "butBackColor"
        Me.butBackColor.Size = New System.Drawing.Size(30, 22)
        Me.butBackColor.Text = "B"
        Me.butBackColor.ToolTipText = "Back color"
        '
        'butForeColor
        '
        Me.butForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.butForeColor.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butForeColor.ForeColor = System.Drawing.Color.Red
        Me.butForeColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butForeColor.Name = "butForeColor"
        Me.butForeColor.Size = New System.Drawing.Size(30, 22)
        Me.butForeColor.Text = "A"
        Me.butForeColor.ToolTipText = "Fore color"
        '
        'butUndo
        '
        Me.butUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butUndo.Image = CType(resources.GetObject("butUndo.Image"), System.Drawing.Image)
        Me.butUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butUndo.Name = "butUndo"
        Me.butUndo.Size = New System.Drawing.Size(23, 22)
        Me.butUndo.ToolTipText = "Undo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpRich
        '
        Me.tlstpRich.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlstpRich.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butFind, Me.butFindReplace, Me.ToolStripSeparator5, Me.butUndo, Me.butRedo, Me.ToolStripSeparator3, Me.butBold, Me.butItalic, Me.butUnderline, Me.ToolStripSeparator1, Me.butBullets, Me.ToolStripSeparator2, Me.butForeColor, Me.butBackColor, Me.ToolStripSeparator4, Me.butShowinRichEditor, Me.cboFonts, Me.cboSize})
        Me.tlstpRich.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tlstpRich.Location = New System.Drawing.Point(0, 0)
        Me.tlstpRich.Name = "tlstpRich"
        Me.tlstpRich.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlstpRich.Size = New System.Drawing.Size(607, 25)
        Me.tlstpRich.TabIndex = 5
        '
        'butFind
        '
        Me.butFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butFind.Image = CType(resources.GetObject("butFind.Image"), System.Drawing.Image)
        Me.butFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butFind.Name = "butFind"
        Me.butFind.Size = New System.Drawing.Size(23, 22)
        Me.butFind.ToolTipText = "Find text"
        '
        'butFindReplace
        '
        Me.butFindReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butFindReplace.Image = CType(resources.GetObject("butFindReplace.Image"), System.Drawing.Image)
        Me.butFindReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butFindReplace.Name = "butFindReplace"
        Me.butFindReplace.Size = New System.Drawing.Size(23, 22)
        Me.butFindReplace.ToolTipText = "Find replace"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'butRedo
        '
        Me.butRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butRedo.Image = CType(resources.GetObject("butRedo.Image"), System.Drawing.Image)
        Me.butRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butRedo.Name = "butRedo"
        Me.butRedo.Size = New System.Drawing.Size(23, 22)
        Me.butRedo.ToolTipText = "Redo"
        '
        'butBold
        '
        Me.butBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.butBold.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butBold.Name = "butBold"
        Me.butBold.Size = New System.Drawing.Size(23, 22)
        Me.butBold.Text = "B"
        Me.butBold.ToolTipText = "Bold"
        '
        'butItalic
        '
        Me.butItalic.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butItalic.Name = "butItalic"
        Me.butItalic.Size = New System.Drawing.Size(23, 22)
        Me.butItalic.Text = "I"
        Me.butItalic.ToolTipText = "Italic"
        '
        'butUnderline
        '
        Me.butUnderline.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butUnderline.Name = "butUnderline"
        Me.butUnderline.Size = New System.Drawing.Size(23, 22)
        Me.butUnderline.Text = "U"
        Me.butUnderline.ToolTipText = "Underline"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'butBullets
        '
        Me.butBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butBullets.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butBullets.Image = CType(resources.GetObject("butBullets.Image"), System.Drawing.Image)
        Me.butBullets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butBullets.Name = "butBullets"
        Me.butBullets.Size = New System.Drawing.Size(23, 22)
        Me.butBullets.ToolTipText = "Bullets"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'butShowinRichEditor
        '
        Me.butShowinRichEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butShowinRichEditor.Image = CType(resources.GetObject("butShowinRichEditor.Image"), System.Drawing.Image)
        Me.butShowinRichEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butShowinRichEditor.Name = "butShowinRichEditor"
        Me.butShowinRichEditor.Size = New System.Drawing.Size(23, 22)
        Me.butShowinRichEditor.ToolTipText = "Bigger view"
        '
        'cboFonts
        '
        Me.cboFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFonts.Name = "cboFonts"
        Me.cboFonts.Size = New System.Drawing.Size(120, 25)
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(75, 25)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'ctxRich
        '
        Me.ctxRich.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectallToolStripMenuItem})
        Me.ctxRich.Name = "ctxRich"
        Me.ctxRich.ShowImageMargin = False
        Me.ctxRich.Size = New System.Drawing.Size(92, 136)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'SelectallToolStripMenuItem
        '
        Me.SelectallToolStripMenuItem.Name = "SelectallToolStripMenuItem"
        Me.SelectallToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.SelectallToolStripMenuItem.Text = "Select &all"
        '
        'ra
        '
        Me.ra.AcceptsTab = True
        Me.ra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ra.ContextMenuStrip = Me.ctxRich
        Me.ra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ra.HideSelection = False
        Me.ra.Location = New System.Drawing.Point(0, 25)
        Me.ra.Name = "ra"
        Me.ra.ShowSelectionMargin = True
        Me.ra.Size = New System.Drawing.Size(607, 423)
        Me.ra.TabIndex = 4
        Me.ra.Text = ""
        '
        'RichTextPlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ra)
        Me.Controls.Add(Me.tlstpRich)
        Me.Name = "RichTextPlus"
        Me.Size = New System.Drawing.Size(607, 448)
        Me.tlstpRich.ResumeLayout(False)
        Me.tlstpRich.PerformLayout()
        Me.ctxRich.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butBackColor As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents butForeColor As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents butUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstpRich As System.Windows.Forms.ToolStrip
    Friend WithEvents butBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents butItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents butUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butBullets As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboFonts As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cdColor As System.Windows.Forms.ColorDialog
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxRich As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ra As RichTextBox
    Friend WithEvents butFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents butFindReplace As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents butShowinRichEditor As System.Windows.Forms.ToolStripButton

End Class
