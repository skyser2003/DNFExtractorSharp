﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ExtractorSharp.View;
using ExtractorSharp.Component;
using ExtractorSharp.Draw;
using ExtractorSharp.Core;
using System.IO;
using ExtractorSharp.Core.Draw;
using ExtractorSharp.Core.Model;
using ExtractorSharp.Avatar.Properties;
using ExtractorSharp.View.Pane;

namespace ExtractorSharp {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            components = new Container();
            albumList = new ESListBox<Album>();
            albumListMenu = albumList.ContextMenuStrip;

            editFileItem = new ToolStripMenuItem();
            cutFileItem = new ToolStripMenuItem();
            copyFileItem = new ToolStripMenuItem();
            pasteFileItem = new ToolStripMenuItem();

            replaceFromFileItem = new ToolStripMenuItem();
            addReplaceItem = new ToolStripMenuItem();
            replaceToThisFileItem = new ToolStripMenuItem();

            saveAsItem = new ToolStripMenuItem();
            newFileItem = new ToolStripMenuItem();
            exchangeFileItem = new ToolStripMenuItem();

            hideImgItem = new ToolStripMenuItem();
            addMergeItem = new ToolStripMenuItem();
            addOutsideMergeItem = new ToolStripMenuItem();
            runMergeItem = new ToolStripMenuItem();
            renameItem = new ToolStripMenuItem();


            repairFileItem = new ToolStripMenuItem();
            recoverFileItem = new ToolStripMenuItem();

            compareFileItem = new ToolStripMenuItem();

            splitFileItem = new ToolStripMenuItem();
            mixFileItem = new ToolStripMenuItem();

            imageList = new ESListBox<Sprite>();
            imageListMenu = imageList.ContextMenuStrip;

            editImageItem = new ToolStripMenuItem();
            cutImageItem = new ToolStripMenuItem();
            copyImageItem = new ToolStripMenuItem();
            pasteImageItem = new ToolStripMenuItem();

            addLayerItem = new ToolStripMenuItem();
            saveImageItem = new ToolStripMenuItem();
            changePositionItem = new ToolStripMenuItem();
            changeSizeItem = new ToolStripMenuItem();

            adjustPositionItem = new ToolStripMenuItem();
            replaceImageItem = new ToolStripMenuItem();
            hideCheckImageItem = new ToolStripMenuItem();
            linkImageItem = new ToolStripMenuItem();
            newImageItem = new ToolStripMenuItem();
            saveSingleImageItem = new ToolStripMenuItem();

            openItem = new ToolStripMenuItem();
            openFileItem = new ToolStripMenuItem();
            openRecentItem = new ToolStripMenuItem();

            addItem = new ToolStripMenuItem();
            addDirItem = new ToolStripMenuItem();
            addRecentItem = new ToolStripMenuItem();

            saveItem = new ToolStripMenuItem();
            saveFileItem = new ToolStripMenuItem();
            saveRecentItem = new ToolStripMenuItem();     
            saveDirItem = new ToolStripMenuItem();

            exitItem = new ToolStripMenuItem();

            convertItem = new ToolStripMenuItem();

            mainMenu = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            addFileItem = new ToolStripMenuItem();
            openDirItem = new ToolStripMenuItem();
            saveAsFileItem = new ToolStripMenuItem();

            linearDodgeItem = new ToolStripMenuItem();
            dyeItem = new ToolStripMenuItem();

            editMenu = new ToolStripMenuItem();
            undoItem = new ToolStripMenuItem();
            redoItem = new ToolStripMenuItem();
            classifyItem = new ToolStripMenuItem();

            moveItem = new ToolStripMenuItem();
            moveUpItem = new ToolStripMenuItem();
            moveDownItem = new ToolStripMenuItem();
            moveLeftItem = new ToolStripMenuItem();
            moveRightItem = new ToolStripMenuItem();

            viewMenu = new ToolStripMenuItem();

            ruleItem = new ToolStripMenuItem();
            displayRuleItem = new ToolStripMenuItem();
            adjustRuleItem = new ToolStripMenuItem();
            previewItem = new ToolStripMenuItem();

            gridItem = new ToolStripMenuItem();
            borderItem = new ToolStripMenuItem();
            
            aboutItem = new ToolStripMenuItem();
            sortItem = new ToolStripMenuItem();

            toolsMenu = new ToolStripMenuItem();

            modelMenu = new ToolStripMenuItem();
            
            saveGifItem = new ToolStripMenuItem();
            box = new PictureBox();
            linearDodgeBox = new CheckBox();
            realPositionBox = new CheckBox();
            dyeBox = new CheckBox();
            displayBox = new CheckBox();

            openButton = new ESButton();
            closeButton = new ESButton();
            historyButton = new ESButton();
            searchIcon = new Label();
            searchBox = new TextBox();
            pathBox = new TextBox();

            scaleLabel = new Label();
            scaleBox = new NumericUpDown();
            pixelateBox = new CheckBox();


            aboutMenu = new ToolStripMenuItem();
            feedbackItem = new ToolStripMenuItem();
            versionItem = new ToolStripMenuItem();
            settingItem = new ToolStripMenuItem();
            helpItem = new ToolStripMenuItem();

            layerList = new ESListBox<IPaint>();
            layerMenu = layerList.ContextMenuStrip;
            upLayerItem = new ToolStripMenuItem();
            downLayerItem = new ToolStripMenuItem();
            renameLayerItem = new ToolStripMenuItem();

            canvasMenu = new ContextMenuStrip();
            canvasCutItem = new ToolStripMenuItem();
            canvasCopyItem = new ToolStripMenuItem();
            canvasPasteItem = new ToolStripMenuItem();
            canvasMoveUpItem = new ToolStripMenuItem();
            canvasMoveDownItem = new ToolStripMenuItem();
            canvasMoveLeftItem = new ToolStripMenuItem();
            canvasMoveRightItem = new ToolStripMenuItem();
            canvasMoveHereItem = new ToolStripMenuItem();


            selectItem = new ToolStripMenuItem();
            selectAllHideItem = new ToolStripMenuItem();
            selectAllLinkItem = new ToolStripMenuItem();
            selectThisLinkItm = new ToolStripMenuItem();
            selectThisTargetItem = new ToolStripMenuItem();

            previewPanel = new Panel();
            colorPanel = new ColorPanel();
            messager = new ESMessager(Connector);

            albumListMenu.SuspendLayout();
            imageListMenu.SuspendLayout();
            mainMenu.SuspendLayout();
            ((ISupportInitialize)(box)).BeginInit();
            SuspendLayout();
            // 
            // albumList
            // 
            albumList.HorizontalScrollbar = true;
            albumList.Location = new Point(20, 90);
            albumList.Name = "albumList";
            albumList.Size = new Size(210, 579);
            albumList.TabIndex = 3;
            albumList.CanClear = false;
            // 
            // albumListMenu
            // 
            albumListMenu.Items.Add(editFileItem);
            albumListMenu.Items.Add(newFileItem);
            albumListMenu.Items.Add(exchangeFileItem);
            albumListMenu.Items.Add(saveAsItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(addReplaceItem);
            albumListMenu.Items.Add(replaceToThisFileItem);
            albumListMenu.Items.Add(replaceFromFileItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(repairFileItem);
            albumListMenu.Items.Add(recoverFileItem);
            albumListMenu.Items.AddSeparator();
            //
            albumListMenu.Items.Add(compareFileItem);
            //
            albumListMenu.Items.Add(splitFileItem);
            albumListMenu.Items.Add(mixFileItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(hideImgItem);
            albumListMenu.Items.Add(renameItem);
            albumListMenu.Items.Add(convertItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(addMergeItem);
            albumListMenu.Items.Add(addOutsideMergeItem);
            albumListMenu.Items.Add(runMergeItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Size = new Size(221, 268);

            editFileItem.Text = Language["Edit"];

            editFileItem.DropDownItems.Add(cutFileItem);
            editFileItem.DropDownItems.Add(copyFileItem);
            editFileItem.DropDownItems.Add(pasteFileItem);

            replaceFromFileItem.Text = Language["ReplaceFromFile"];
            replaceFromFileItem.ShortcutKeys = Keys.Control | Keys.Q;
            replaceFromFileItem.Image = Resources.replace;


            addReplaceItem.Text = Language["AddReplace"];
            addReplaceItem.ShortcutKeys = Keys.Control | Keys.W;

            replaceToThisFileItem.Text = Language["ReplaceToThisFile"];
            replaceToThisFileItem.ShortcutKeys = Keys.Control | Keys.E;



            cutFileItem.Text = Language["Cut"];
            cutFileItem.ShortcutKeys = Keys.Control | Keys.X;
            cutFileItem.Image = Resources.cut;

            copyFileItem.Text = Language["Copy"];
            copyFileItem.ShortcutKeys = Keys.Control | Keys.C;
            copyFileItem.Image = Resources.copy;

            pasteFileItem.Text = Language["Paste"];
            pasteFileItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteFileItem.Image = Resources.paste;

            saveAsItem.Text = Language["SaveAs"];
            saveAsItem.ShortcutKeys = Keys.Control | Keys.E;
            saveAsItem.Image = Resources.saveAs;

            newFileItem.Text = Language["NewFile"];
            newFileItem.ShortcutKeys = Keys.Control | Keys.N;
            newFileItem.Image = Resources.newFile;


            exchangeFileItem.Text = Language["ExchangeFile"];
            exchangeFileItem.ShortcutKeys = Keys.Control | Keys.G;

            hideImgItem.Text = Language["HideFile"];
            hideImgItem.ShortcutKeys = Keys.Control | Keys.H;

            convertItem.Text = Language["ConvertVersion"];
            convertItem.Image = Resources.change;

            addMergeItem.Text = Language["AddMerge"];
            addMergeItem.ShortcutKeys = Keys.Control | Keys.M;
            addMergeItem.Image = Resources.addFile;

            addOutsideMergeItem.Text = Language["AddOutsideMerge"];
            addOutsideMergeItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;

            runMergeItem.Text = Language["RunMerge"];
            runMergeItem.Image = Resources.play;

            renameItem.Text = Language["Rename"];
            renameItem.ShortcutKeys = Keys.Control | Keys.R;
            renameItem.Image = Resources.rename;

            repairFileItem.Text = Language["RepairFile"];
            repairFileItem.Image = Resources.repair;

            recoverFileItem.Text = Language["RecoverFile"];

            compareFileItem.Text = Language["CompareFile"];

            splitFileItem.Text = Language["SplitFile"];
            mixFileItem.Text = Language["MixFile"];
            // 
            // imageList
            // 
            imageList.HorizontalScrollbar = true;
            imageList.Location = new Point(1070, 90);
            imageList.Name = "imageList";
            imageList.Size = new Size(270, 310);
            imageList.TabIndex = 4;
            imageList.CanClear = false;
            // 
            // imageListMenu
            // 
            imageListMenu.Items.Add(selectItem);
            imageListMenu.Items.AddSeparator();
            imageListMenu.Items.Add(editImageItem);
            imageListMenu.Items.AddSeparator();
            imageListMenu.Items.Add(newImageItem);
            imageListMenu.Items.Add(replaceImageItem);
            imageListMenu.Items.AddSeparator();
            imageListMenu.Items.Add(changePositionItem);
            imageListMenu.Items.Add(changeSizeItem);
            imageListMenu.Items.AddSeparator();
            imageListMenu.Items.Add(saveImageItem);
            imageListMenu.Items.Add(saveSingleImageItem);
            imageListMenu.Items.Add(saveGifItem);
            imageListMenu.Items.AddSeparator();
            imageListMenu.Items.Add(hideCheckImageItem);
            imageListMenu.Items.Add(linkImageItem);
            imageListMenu.Items.Add(addLayerItem);
            imageListMenu.Name = "imageListMenu";
            imageListMenu.Size = new Size(161, 202);

            editImageItem.Text = Language["Edit"];

            editImageItem.DropDownItems.Add(cutImageItem);
            editImageItem.DropDownItems.Add(copyImageItem);
            editImageItem.DropDownItems.Add(pasteImageItem);
            editImageItem.DropDownItems.AddSeparator();
            editImageItem.DropDownItems.Add(linearDodgeItem);
            editImageItem.DropDownItems.Add(dyeItem);

            cutImageItem.Text = Language["Cut"];
            cutImageItem.Image = Resources.cut;

            copyImageItem.Text = Language["Copy"];
            copyImageItem.Image = Resources.copy;

            pasteImageItem.Text = Language["Paste"];
            pasteImageItem.Image = Resources.paste;

            linearDodgeItem.Text = Language["LinearDodge"];

            dyeItem.Text = Language["Dye"];


            saveImageItem.Text = Language["SaveImage"];
            saveImageItem.Image = Resources.save;

            saveSingleImageItem.Text = Language["SaveAs"];
            saveSingleImageItem.Image = Resources.saveAs;
           
            saveGifItem.Text = Language["SaveGif"];

            saveGifItem.Image = Resources.gif;

            changePositionItem.Text = Language["ChangeImagePosition"];
            changePositionItem.Image = Resources.position;

            changeSizeItem.Text = Language["ChangeImageSize"];
            changeSizeItem.Image = Resources.edit;

            replaceImageItem.Text = Language["ReplaceImage"];
            replaceImageItem.Image = Resources.replace;

            hideCheckImageItem.Text = Language["HideImage"];
            linkImageItem.Text = Language["LinkImage"];
            linkImageItem.Image = Resources.link;

            newImageItem.Text = Language["NewImage"];
            newImageItem.Image = Resources.newFile;

            addLayerItem.Text = Language["AddLayer"];


            selectItem.Text = Language["Select"];
            selectAllHideItem.Text = Language["SelectHide"];
            selectAllLinkItem.Text = Language["SelectLink"];
            selectThisLinkItm.Text = Language["SelectThisLink"];
            selectThisTargetItem.Text = Language["SelectThisTarget"];

            selectItem.DropDownItems.Add(selectAllHideItem);
            selectItem.DropDownItems.Add(selectAllLinkItem);
            selectItem.DropDownItems.Add(selectThisLinkItm);
            selectItem.DropDownItems.Add(selectThisTargetItem);

            // 
            // mainMenu
            // 
            mainMenu.BackColor = Config["MainColor"].Color;
            mainMenu.Items.Add(fileMenu);
            mainMenu.Items.Add(editMenu);
            mainMenu.Items.Add(viewMenu);
            mainMenu.Items.Add(toolsMenu);
            mainMenu.Items.Add(modelMenu);
            mainMenu.Items.Add(aboutMenu);

            modelMenu.Text = Language["Model"];

            aboutMenu.Text = Language["About"];
            aboutMenu.DropDownItems.Add(aboutItem);
            aboutMenu.DropDownItems.Add(helpItem);
            aboutMenu.DropDownItems.Add(versionItem);
            aboutMenu.DropDownItems.Add(feedbackItem);
            aboutMenu.DropDownItems.Add(settingItem);
            aboutItem.Text = Language["About"];
            aboutItem.Image = Resources.about;

            versionItem.Text = Language["Features"];

            feedbackItem.Text = Language["FeedBack"];
            feedbackItem.Image = Resources.feedback;

            helpItem.Text = Language["Help"];
            helpItem.Image = Resources.help;
            
            settingItem.Text = Language["Setting"];
            settingItem.Image = Resources.setting;

            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.Add(openItem);
            fileMenu.DropDownItems.Add(addItem);
            fileMenu.DropDownItems.AddSeparator();
            fileMenu.DropDownItems.Add(saveItem);
            fileMenu.DropDownItems.Add(saveAsFileItem);
            fileMenu.DropDownItems.AddSeparator();
            fileMenu.DropDownItems.Add(exitItem);
            fileMenu.Text = Language["File"];

            openItem.Text = Language["Open"];
            openItem.ShowShortcutKeys = false;
            openItem.Image = Resources.open;

            openFileItem.Text = Language["File"];
            openFileItem.ShowShortcutKeys = false;
            openFileItem.ShortcutKeys = Keys.Control | Keys.O;

            openDirItem.Text = Language["Directory"];
            openRecentItem.Text = Language["Recent"];
            openRecentItem.DropDownItems.AddSeparator();

            openItem.DropDownItems.Add(openFileItem);
            openItem.DropDownItems.Add(openDirItem);
            openItem.DropDownItems.Add(openRecentItem);


            addItem.Text = Language["Add"];
            addItem.Image = Resources.addFile;
            addRecentItem.Text = Language["Recent"];
            addRecentItem.DropDownItems.AddSeparator();


            addFileItem.Text = Language["File"];
            addFileItem.ShowShortcutKeys = false;
            addFileItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;

            addDirItem.Text = Language["Directory"];

            addItem.DropDownItems.Add(addFileItem);
            addItem.DropDownItems.Add(addDirItem);
            addItem.DropDownItems.Add(addRecentItem);


            saveItem.Text = Language["Save"];
            saveItem.ShowShortcutKeys = false;
            saveItem.Image = Resources.save;
            saveRecentItem.Text = Language["Recent"];
            saveRecentItem.DropDownItems.AddSeparator();

            saveFileItem.Text = Language["File"];
            saveFileItem.ShortcutKeys = Keys.Control | Keys.S;
            saveDirItem.Text = Language["Directory"];

            saveItem.DropDownItems.Add(saveFileItem);
            saveItem.DropDownItems.Add(saveDirItem);
            saveItem.DropDownItems.Add(saveRecentItem);

            saveAsFileItem.Text = Language["SaveAs"];
            saveAsFileItem.ShowShortcutKeys = false;
            saveAsFileItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsFileItem.Image = Resources.saveAs;


            exitItem.Text = Language["Exit"];
            exitItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitItem.ShowShortcutKeys = false;
            exitItem.Image = Resources.exit;

            editMenu.Text = Language["Edit"];
            editMenu.DropDownItems.Add(undoItem);
            editMenu.DropDownItems.Add(redoItem);
            editMenu.DropDownItems.AddSeparator();
            editMenu.DropDownItems.Add(moveItem);
            editMenu.DropDownItems.Add(adjustPositionItem);
            editMenu.DropDownItems.AddSeparator();
            editMenu.DropDownItems.Add(classifyItem);
            editMenu.DropDownItems.Add(sortItem);
            undoItem.Text = Language["Undo"];
            undoItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoItem.Image = Resources.undo;

            redoItem.Text = Language["Redo"];
            redoItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoItem.Image = Resources.redo;

            classifyItem.Text = Language["Classify"];
            classifyItem.CheckOnClick = true;
            classifyItem.Image = Resources.classify;

            sortItem.Text = Language["Sort"];
            sortItem.Image = Resources.sort;

            moveItem.Text = Language["Move"];
            moveItem.DropDownItems.Add(moveUpItem);
            moveItem.DropDownItems.Add(moveDownItem);
            moveItem.DropDownItems.Add(moveLeftItem);
            moveItem.DropDownItems.Add(moveRightItem);

            moveUpItem.Text = Language["MoveUp"];
            moveUpItem.ShortcutKeys = Keys.Control | Keys.Up;
            moveDownItem.Text = Language["MoveDown"];
            moveDownItem.ShortcutKeys = Keys.Control | Keys.Down;
            moveLeftItem.Text = Language["MoveLeft"];
            moveLeftItem.ShortcutKeys = Keys.Control | Keys.Left;
            moveRightItem.Text = Language["MoveRight"];
            moveRightItem.ShortcutKeys = Keys.Control | Keys.Right;

            adjustPositionItem.Text = Language["AdjustPosition"];
            adjustPositionItem.ShortcutKeys = Keys.Control | Keys.B;


            viewMenu.Text = Language["View"];
            viewMenu.DropDownItems.Add(ruleItem);
            viewMenu.DropDownItems.Add(gridItem);
            viewMenu.DropDownItems.Add(borderItem);
            viewMenu.DropDownItems.Add(previewItem);

            ruleItem.Text = Language["Ruler"];
            ruleItem.Image = Resources.ruler;
            ruleItem.DropDownItems.Add(displayRuleItem);
            ruleItem.DropDownItems.Add(adjustRuleItem);

            displayRuleItem.Text = Language["DisplayRuler"];
            displayRuleItem.Checked = Config["Ruler"].Boolean;
            displayRuleItem.ShortcutKeys = Keys.Control | Keys.N;
            displayRuleItem.ShowShortcutKeys = true;
            displayRuleItem.CheckOnClick = true;
            
            adjustRuleItem.Text = Language["ResetRuler"];

            previewItem.Text = Language["Preview"];
            previewItem.CheckOnClick = true;
            previewItem.Checked = Config["Preview"].Boolean;
            gridItem.Text = Language["Grid"];
            gridItem.Checked = Config["Grid"].Boolean;
            gridItem.Image = Resources.grid;
            borderItem.Text = Language["Border"];
            borderItem.Checked = Config["Border"].Boolean;


            toolsMenu.Text = Language["Tools"];
            
            // 
            // Message
            // 
            messager.Location = new Point(1072, 25);

            openButton.Location = new Point(20, 63);
            openButton.Text = Language["Open"];
            openButton.Size = new Size(75, 25);
            openButton.UseVisualStyleBackColor = true;

            closeButton.Location = new Point(155, 63);
            closeButton.Text = Language["Close"];
            closeButton.Size = new Size(75, 25);
            closeButton.UseVisualStyleBackColor = true;

            pathBox.Location = new Point(20, 40);
            pathBox.Size = new Size(210, 20);
            // 
            // box
            // 
            box.Location = new Point(230, 90);
            box.Name = "box";
            box.BackColor = Color.Gray;
            if (Config["CanvasSize"].Size != Size.Empty) { 
                box.Size = Config["CanvasSize"].Size;
            }
            //
            //colorPanel
            //
            colorPanel.Location = new Point(800, 48);
            colorPanel.Color = Config["BrushColor"].Color;
            ///
            ///
            ///
            scaleLabel.AutoSize = true;
            scaleLabel.Text = $"{Language["CanvasScale"]}(%)";
            scaleLabel.Location = new Point(250, 53);

            ///
            ///
            ///
            scaleBox.Size = new Size(100, 40);
            scaleBox.Location = new Point(320, 50);
            scaleBox.Minimum = 20;
            scaleBox.Maximum = 100000;


            //
            //
            //
            pixelateBox.Text = Language["Pixelate"];
            pixelateBox.Location = new Point(430, 50);

            // 
            // realPositionBox
            // 
            realPositionBox.Location = new Point(1085, 60);
            realPositionBox.Name = "realPositionBox";
            realPositionBox.AutoSize = true;
            realPositionBox.TabIndex = 11;
            realPositionBox.Text = Language["RealPosition"];
            //
            //
            //
            displayBox.Location = new Point(1210, 60);
            displayBox.AutoSize = true;
            displayBox.Text = Language["Animation"];
            //
            //
            //
            linearDodgeBox.Location = new Point(1085, 30);
            linearDodgeBox.AutoSize = true;
            linearDodgeBox.Text = Language["LinearDodge"];
            ///
            //
            //
            dyeBox.Location = new Point(1210, 30);
            dyeBox.AutoSize = true;
            dyeBox.Text = Language["Dye"];
            //
            //
            //
            historyButton.Location = new Point(945, 47);
            historyButton.AutoSize = true;
            historyButton.Size = new Size(85, 25);
            historyButton.Text = Language["Other"];
            historyButton.UseVisualStyleBackColor = true;

            searchIcon.Location = new Point(204, 672);
            searchIcon.Size = new Size(16, 16);
            searchIcon.Image = Resources.search;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(20, 668);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(180, 20);
            searchBox.TabIndex = 6;


            layerList.HorizontalScrollbar = true;
            layerList.Location = new Point(1070, 397);
            layerList.Name = "layerList";
            layerList.Size = new Size(270, 305);
            layerList.TabIndex = 4;
            layerList.CanClear = false;
            layerList.CanDelete = true;


            layerMenu.Items.Add(upLayerItem);
            layerMenu.Items.Add(downLayerItem);
            layerMenu.Items.Add(renameLayerItem);

            upLayerItem.Text = Language["MoveUp"];
            downLayerItem.Text = Language["MoveDown"];
            renameLayerItem.Text = Language["Rename"];



            colorDialog = new ColorDialog();

            canvasMenu.Items.Add(canvasCutItem);
            canvasMenu.Items.Add(canvasCopyItem);
            canvasMenu.Items.Add(canvasPasteItem);
            canvasMenu.Items.AddSeparator();
            canvasMenu.Items.Add(canvasMoveUpItem);
            canvasMenu.Items.Add(canvasMoveDownItem);
            canvasMenu.Items.Add(canvasMoveLeftItem);
            canvasMenu.Items.Add(canvasMoveRightItem);
            canvasMenu.Items.Add(canvasMoveHereItem);

            canvasCutItem.Text = Language["Cut"];
            canvasCutItem.ShortcutKeys = Keys.Control | Keys.X;
            canvasCutItem.Image = Resources.cut;

            canvasCopyItem.Text = Language["Copy"];
            canvasCopyItem.ShortcutKeys = Keys.Control | Keys.C;
            canvasCopyItem.Image = Resources.copy;

            canvasPasteItem.Text = Language["Paste"];
            canvasPasteItem.ShortcutKeys = Keys.Control | Keys.V;
            canvasPasteItem.Image = Resources.paste;

            canvasMoveUpItem.Text = Language["MoveUp"];
            canvasMoveUpItem.ShortcutKeys = Keys.Control | Keys.Up;

            canvasMoveDownItem.Text = Language["MoveDown"];
            canvasMoveDownItem.ShortcutKeys = Keys.Control | Keys.Down;

            canvasMoveLeftItem.Text = Language["MoveLeft"];
            canvasMoveLeftItem.ShortcutKeys = Keys.Control | Keys.Left;

            canvasMoveRightItem.Text = Language["MoveRight"];
            canvasMoveRightItem.ShortcutKeys = Keys.Control | Keys.Right;

            canvasMoveHereItem.Text = Language["MoveHere"];
            
           

            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(imageList);
            Controls.Add(mainMenu);
            Controls.Add(searchIcon);
            Controls.Add(searchBox);
            Controls.Add(albumList);
            Controls.Add(layerList);
            Controls.Add(messager);
            Controls.Add(openButton);
            Controls.Add(closeButton);
            Controls.Add(pathBox);
            Controls.Add(realPositionBox);
            Controls.Add(displayBox);
            Controls.Add(linearDodgeBox);
            Controls.Add(dyeBox);
            Controls.Add(box);
            Controls.Add(historyButton);
            Controls.Add(colorPanel);
            Controls.Add(scaleLabel);
            Controls.Add(scaleBox);
            Controls.Add(pixelateBox);
            Controls.Add(previewPanel);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = $"{ProductName} Ver { Program.Version} { Config["Title"]}";
            AllowDrop = true;
            ClientSize = Config["MainSize"].Size;
            BackColor = Config["MainColor"].Color;
            albumListMenu.ResumeLayout(false);
            imageListMenu.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();

            previewPanel.Visible = Config["Preview"].Boolean;
            previewPanel.BorderStyle = BorderStyle.FixedSingle;
            previewPanel.Size = new Size(150, 150);
            previewPanel.BackgroundImageLayout = ImageLayout.Zoom;
            previewPanel.Location = new System.Drawing.Point(920, 90);
            ((ISupportInitialize)(box)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private ESListBox<Album> albumList;
        private ESListBox<Sprite> imageList;
        private ESListBox<IPaint> layerList;

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileMenu;

        private ToolStripMenuItem openItem;
        private ToolStripMenuItem openFileItem;
        private ToolStripMenuItem openDirItem;
        private ToolStripMenuItem openRecentItem;

        private ToolStripMenuItem addItem;
        private ToolStripMenuItem addFileItem;
        private ToolStripMenuItem addDirItem;
        private ToolStripMenuItem addRecentItem;

        private ToolStripMenuItem saveItem;
        private ToolStripMenuItem saveFileItem;
        private ToolStripMenuItem saveDirItem;
        private ToolStripMenuItem saveRecentItem;

        private ToolStripMenuItem saveAsFileItem;

        private ToolStripMenuItem exitItem;

        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoItem;
        private ToolStripMenuItem redoItem;
        private ToolStripMenuItem classifyItem;     //分类
        private ToolStripMenuItem sortItem;         //

        private ToolStripMenuItem moveItem;
        private ToolStripMenuItem moveUpItem;
        private ToolStripMenuItem moveDownItem;
        private ToolStripMenuItem moveLeftItem;   
        private ToolStripMenuItem moveRightItem;

        private ToolStripMenuItem aboutMenu;        //关于
        private ToolStripMenuItem aboutItem;        //关于
        private ToolStripMenuItem feedbackItem;        //问题反馈
        private ToolStripMenuItem versionItem;      //版本特性
        private ToolStripMenuItem settingItem;     //设置
        private ToolStripMenuItem helpItem;        //帮助

        private ToolStripMenuItem viewMenu;         //视图
        private ToolStripMenuItem ruleItem;         //标尺
        private ToolStripMenuItem displayRuleItem;  //显示标尺
        private ToolStripMenuItem adjustRuleItem;   //校正标尺
        private ToolStripMenuItem previewItem;      //贴图预览

        private ToolStripMenuItem gridItem;         //网格
        private ToolStripMenuItem borderItem;       //边框

        private ToolStripMenuItem toolsMenu;        //工具

        private ToolStripMenuItem modelMenu;      //模型管理

        private ContextMenuStrip albumListMenu;
        private ToolStripMenuItem newFileItem;       //新建文件
        private ToolStripMenuItem replaceFromFileItem;      //替换到外部文件
        private ToolStripMenuItem replaceToThisFileItem;   //替换到该文件
        private ToolStripMenuItem addReplaceItem;    //加入替换

        private ToolStripMenuItem exchangeFileItem;  //互换文件


        private ToolStripMenuItem editFileItem;      
        private ToolStripMenuItem cutFileItem;       //剪切
        private ToolStripMenuItem copyFileItem;      //复制
        private ToolStripMenuItem pasteFileItem;     //粘贴

        private ToolStripMenuItem saveAsItem;       //另存为
        private ToolStripMenuItem renameItem;       //重命名
        private ToolStripMenuItem convertItem;      //转换版本
        private ToolStripMenuItem hideImgItem;      //隐藏文件内所有贴图
        private ToolStripMenuItem addMergeItem;    //加入拼合队列
        private ToolStripMenuItem addOutsideMergeItem;//加入外部文件到拼合队列
        private ToolStripMenuItem runMergeItem;    //执行拼合队列

        private ToolStripMenuItem repairFileItem;    //修复文件
        private ToolStripMenuItem recoverFileItem;   //恢复文件
        private ToolStripMenuItem compareFileItem;   //对比文件
        private ToolStripMenuItem splitFileItem;     //拆分文件
        private ToolStripMenuItem mixFileItem;       //合并文件

        private ContextMenuStrip imageListMenu;

        private ToolStripMenuItem editImageItem;
        private ToolStripMenuItem cutImageItem;     //剪切
        private ToolStripMenuItem copyImageItem;    //复制
        private ToolStripMenuItem pasteImageItem;   //粘贴

        private ToolStripMenuItem saveImageItem;    //提取贴图到文件夹
        private ToolStripMenuItem saveSingleImageItem;   //提取贴图
        private ToolStripMenuItem saveGifItem;      //保存为gif
        private ToolStripMenuItem changePositionItem;//修改坐标
        private ToolStripMenuItem changeSizeItem;    //修改大小
        private ToolStripMenuItem replaceImageItem;  //替换贴图
        private ToolStripMenuItem hideCheckImageItem;//隐藏贴图
        private ToolStripMenuItem linkImageItem;     //修改为链接贴图
        private ToolStripMenuItem newImageItem; //新建贴图;


        private ToolStripMenuItem adjustPositionItem;//校正坐标
        private ToolStripMenuItem addLayerItem; //加入图层

        private ToolStripMenuItem linearDodgeItem;
        private ToolStripMenuItem dyeItem;

        private ColorDialog colorDialog;

        private ContextMenuStrip layerMenu;
        private ToolStripMenuItem upLayerItem;
        private ToolStripMenuItem downLayerItem;
        private ToolStripMenuItem renameLayerItem;

        
        private CheckBox realPositionBox;        //真实坐标
        private CheckBox displayBox;            //动画播放
        private CheckBox linearDodgeBox;          //线性减淡
        private CheckBox dyeBox;             //染色

        private Label scaleLabel;
        private NumericUpDown scaleBox;         //画布比例
        private CheckBox pixelateBox;              //像素化


        private Button openButton;              //打开文件
        private Button closeButton;             //关闭文件
        private PictureBox box;
        private TextBox searchBox;
        private Label searchIcon;
        private TextBox pathBox;
        private Button historyButton;           //历史操作



        private ContextMenuStrip canvasMenu;
        private ToolStripMenuItem canvasCutItem;
        private ToolStripMenuItem canvasCopyItem;
        private ToolStripMenuItem canvasPasteItem;
        private ToolStripMenuItem canvasMoveUpItem;
        private ToolStripMenuItem canvasMoveDownItem;
        private ToolStripMenuItem canvasMoveLeftItem;
        private ToolStripMenuItem canvasMoveRightItem;
        private ToolStripMenuItem canvasMoveHereItem;

        private ToolStripMenuItem selectItem;
        private ToolStripMenuItem selectAllLinkItem;
        private ToolStripMenuItem selectThisLinkItm;
        private ToolStripMenuItem selectThisTargetItem;
        private ToolStripMenuItem selectAllHideItem;

        private DropPanel dropPanel;
        private AudioPlayer player;
        private Panel previewPanel;
        private ColorPanel colorPanel;
        private ESMessager messager;
    }
}

