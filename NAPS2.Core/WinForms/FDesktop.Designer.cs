using System;
using System.Collections.Generic;
using System.Linq;
using NAPS2.Update;

namespace NAPS2.WinForms
{
    partial class FDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDesktop));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnQuickScan = new System.Windows.Forms.Button();
            this.thumbnailList1 = new NAPS2.WinForms.ThumbnailList();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxView = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsScan = new System.Windows.Forms.ToolStripButton();
            this.tsProfiles = new System.Windows.Forms.ToolStripButton();
            this.tsOcr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdSavePDF = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSavePDFAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSavePDFSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdSaveImages = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSaveImagesAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveImagesSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdEmailPDF = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsEmailPDFAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmailPDFSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdRotate = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsRotateLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRotateRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tsdReorder = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsInterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeinterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAbout = new System.Windows.Forms.ToolStripButton();
            this.tsReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReverseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReverseSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnQuickScan);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.thumbnailList1);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tStrip);
            // 
            // btnQuickScan
            // 
            this.btnQuickScan.Image = global::NAPS2.Icons.control_play_blue_small;
            resources.ApplyResources(this.btnQuickScan, "btnQuickScan");
            this.btnQuickScan.Name = "btnQuickScan";
            this.btnQuickScan.UseVisualStyleBackColor = true;
            this.btnQuickScan.Click += new System.EventHandler(this.btnQuickScan_Click);
            // 
            // thumbnailList1
            // 
            this.thumbnailList1.ContextMenuStrip = this.contextMenuStrip;
            resources.ApplyResources(this.thumbnailList1, "thumbnailList1");
            this.thumbnailList1.Name = "thumbnailList1";
            this.thumbnailList1.UseCompatibleStateImageBehavior = false;
            this.thumbnailList1.ItemActivate += new System.EventHandler(this.thumbnailList1_ItemActivate);
            this.thumbnailList1.SelectedIndexChanged += new System.EventHandler(this.thumbnailList1_SelectedIndexChanged);
            this.thumbnailList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thumbnailList1_KeyDown);
            this.thumbnailList1.MouseLeave += new System.EventHandler(this.thumbnailList1_MouseLeave);
            this.thumbnailList1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thumbnailList1_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxView,
            this.ctxSelectAll,
            this.ctxCopy});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // ctxView
            // 
            resources.ApplyResources(this.ctxView, "ctxView");
            this.ctxView.Name = "ctxView";
            this.ctxView.Click += new System.EventHandler(this.ctxView_Click);
            // 
            // ctxSelectAll
            // 
            this.ctxSelectAll.Name = "ctxSelectAll";
            resources.ApplyResources(this.ctxSelectAll, "ctxSelectAll");
            this.ctxSelectAll.Click += new System.EventHandler(this.ctxSelectAll_Click);
            // 
            // ctxCopy
            // 
            this.ctxCopy.Name = "ctxCopy";
            resources.ApplyResources(this.ctxCopy, "ctxCopy");
            this.ctxCopy.Click += new System.EventHandler(this.ctxCopy_Click);
            // 
            // tStrip
            // 
            resources.ApplyResources(this.tStrip, "tStrip");
            this.tStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsScan,
            this.tsProfiles,
            this.tsOcr,
            this.toolStripSeparator5,
            this.tsdSavePDF,
            this.tsdSaveImages,
            this.tsdEmailPDF,
            this.tsImport,
            this.toolStripSeparator4,
            this.tsdRotate,
            this.tsMoveUp,
            this.tsMoveDown,
            this.tsdReorder,
            this.toolStripSeparator2,
            this.tsDelete,
            this.tsClear,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.tsAbout});
            this.tStrip.Name = "tStrip";
            this.tStrip.ShowItemToolTips = false;
            // 
            // tsScan
            // 
            resources.ApplyResources(this.tsScan, "tsScan");
            this.tsScan.Name = "tsScan";
            this.tsScan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsScan.Click += new System.EventHandler(this.tsScan_Click);
            // 
            // tsProfiles
            // 
            resources.ApplyResources(this.tsProfiles, "tsProfiles");
            this.tsProfiles.Name = "tsProfiles";
            this.tsProfiles.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsProfiles.Click += new System.EventHandler(this.tsProfiles_Click);
            // 
            // tsOcr
            // 
            this.tsOcr.Image = global::NAPS2.Icons.text;
            resources.ApplyResources(this.tsOcr, "tsOcr");
            this.tsOcr.Name = "tsOcr";
            this.tsOcr.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsOcr.Click += new System.EventHandler(this.tsOcr_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // tsdSavePDF
            // 
            this.tsdSavePDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSavePDFAll,
            this.tsSavePDFSelected});
            this.tsdSavePDF.Image = global::NAPS2.Icons.file_extension_pdf;
            resources.ApplyResources(this.tsdSavePDF, "tsdSavePDF");
            this.tsdSavePDF.Name = "tsdSavePDF";
            this.tsdSavePDF.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdSavePDF.ShowDropDownArrow = false;
            // 
            // tsSavePDFAll
            // 
            this.tsSavePDFAll.Name = "tsSavePDFAll";
            resources.ApplyResources(this.tsSavePDFAll, "tsSavePDFAll");
            this.tsSavePDFAll.Click += new System.EventHandler(this.tsSavePDFAll_Click);
            // 
            // tsSavePDFSelected
            // 
            this.tsSavePDFSelected.Name = "tsSavePDFSelected";
            resources.ApplyResources(this.tsSavePDFSelected, "tsSavePDFSelected");
            this.tsSavePDFSelected.Click += new System.EventHandler(this.tsSavePDFSelected_Click);
            // 
            // tsdSaveImages
            // 
            this.tsdSaveImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveImagesAll,
            this.tsSaveImagesSelected});
            this.tsdSaveImages.Image = global::NAPS2.Icons.picture;
            resources.ApplyResources(this.tsdSaveImages, "tsdSaveImages");
            this.tsdSaveImages.Name = "tsdSaveImages";
            this.tsdSaveImages.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdSaveImages.ShowDropDownArrow = false;
            // 
            // tsSaveImagesAll
            // 
            this.tsSaveImagesAll.Name = "tsSaveImagesAll";
            resources.ApplyResources(this.tsSaveImagesAll, "tsSaveImagesAll");
            this.tsSaveImagesAll.Click += new System.EventHandler(this.tsSaveImagesAll_Click);
            // 
            // tsSaveImagesSelected
            // 
            this.tsSaveImagesSelected.Name = "tsSaveImagesSelected";
            resources.ApplyResources(this.tsSaveImagesSelected, "tsSaveImagesSelected");
            this.tsSaveImagesSelected.Click += new System.EventHandler(this.tsSaveImagesSelected_Click);
            // 
            // tsdEmailPDF
            // 
            this.tsdEmailPDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmailPDFAll,
            this.tsEmailPDFSelected});
            this.tsdEmailPDF.Image = global::NAPS2.Icons.email_attach;
            resources.ApplyResources(this.tsdEmailPDF, "tsdEmailPDF");
            this.tsdEmailPDF.Name = "tsdEmailPDF";
            this.tsdEmailPDF.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdEmailPDF.ShowDropDownArrow = false;
            // 
            // tsEmailPDFAll
            // 
            this.tsEmailPDFAll.Name = "tsEmailPDFAll";
            resources.ApplyResources(this.tsEmailPDFAll, "tsEmailPDFAll");
            this.tsEmailPDFAll.Click += new System.EventHandler(this.tsEmailPDFAll_Click);
            // 
            // tsEmailPDFSelected
            // 
            this.tsEmailPDFSelected.Name = "tsEmailPDFSelected";
            resources.ApplyResources(this.tsEmailPDFSelected, "tsEmailPDFSelected");
            this.tsEmailPDFSelected.Click += new System.EventHandler(this.tsEmailPDFSelected_Click);
            // 
            // tsImport
            // 
            this.tsImport.Image = global::NAPS2.Icons.folder_picture;
            resources.ApplyResources(this.tsImport, "tsImport");
            this.tsImport.Name = "tsImport";
            this.tsImport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsImport.Click += new System.EventHandler(this.tsImport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsdRotate
            // 
            this.tsdRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRotateLeft,
            this.tsRotateRight,
            this.tsFlip});
            this.tsdRotate.Image = global::NAPS2.Icons.arrow_rotate_anticlockwise;
            resources.ApplyResources(this.tsdRotate, "tsdRotate");
            this.tsdRotate.Name = "tsdRotate";
            this.tsdRotate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdRotate.ShowDropDownArrow = false;
            // 
            // tsRotateLeft
            // 
            this.tsRotateLeft.Image = global::NAPS2.Icons.arrow_rotate_anticlockwise_small;
            resources.ApplyResources(this.tsRotateLeft, "tsRotateLeft");
            this.tsRotateLeft.Name = "tsRotateLeft";
            this.tsRotateLeft.Click += new System.EventHandler(this.tsRotateLeft_Click);
            // 
            // tsRotateRight
            // 
            this.tsRotateRight.Image = global::NAPS2.Icons.arrow_rotate_clockwise_small;
            resources.ApplyResources(this.tsRotateRight, "tsRotateRight");
            this.tsRotateRight.Name = "tsRotateRight";
            this.tsRotateRight.Click += new System.EventHandler(this.tsRotateRight_Click);
            // 
            // tsFlip
            // 
            this.tsFlip.Image = global::NAPS2.Icons.arrow_switch_small;
            resources.ApplyResources(this.tsFlip, "tsFlip");
            this.tsFlip.Name = "tsFlip";
            this.tsFlip.Click += new System.EventHandler(this.tsFlip_Click);
            // 
            // tsMoveUp
            // 
            this.tsMoveUp.Image = global::NAPS2.Icons.arrow_up;
            resources.ApplyResources(this.tsMoveUp, "tsMoveUp");
            this.tsMoveUp.Name = "tsMoveUp";
            this.tsMoveUp.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsMoveUp.Click += new System.EventHandler(this.tsMoveUp_Click);
            // 
            // tsMoveDown
            // 
            this.tsMoveDown.Image = global::NAPS2.Icons.arrow_down;
            resources.ApplyResources(this.tsMoveDown, "tsMoveDown");
            this.tsMoveDown.Name = "tsMoveDown";
            this.tsMoveDown.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsMoveDown.Click += new System.EventHandler(this.tsMoveDown_Click);
            // 
            // tsdReorder
            // 
            this.tsdReorder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInterleave,
            this.tsDeinterleave,
            this.toolStripSeparator1,
            this.tsReverse});
            this.tsdReorder.Image = global::NAPS2.Icons.arrow_refresh;
            resources.ApplyResources(this.tsdReorder, "tsdReorder");
            this.tsdReorder.Name = "tsdReorder";
            this.tsdReorder.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdReorder.ShowDropDownArrow = false;
            // 
            // tsInterleave
            // 
            this.tsInterleave.Name = "tsInterleave";
            resources.ApplyResources(this.tsInterleave, "tsInterleave");
            this.tsInterleave.Click += new System.EventHandler(this.tsInterleave_Click);
            // 
            // tsDeinterleave
            // 
            this.tsDeinterleave.Name = "tsDeinterleave";
            resources.ApplyResources(this.tsDeinterleave, "tsDeinterleave");
            this.tsDeinterleave.Click += new System.EventHandler(this.tsDeinterleave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::NAPS2.Icons.cross;
            resources.ApplyResources(this.tsDelete, "tsDelete");
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsClear
            // 
            this.tsClear.Image = global::NAPS2.Icons.cancel;
            resources.ApplyResources(this.tsClear, "tsClear");
            this.tsClear.Name = "tsClear";
            this.tsClear.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Image = global::NAPS2.Icons.world;
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            // 
            // tsAbout
            // 
            resources.ApplyResources(this.tsAbout, "tsAbout");
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // tsReverse
            // 
            this.tsReverse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReverseAll,
            this.tsReverseSelected});
            this.tsReverse.Name = "tsReverse";
            resources.ApplyResources(this.tsReverse, "tsReverse");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsReverseAll
            // 
            this.tsReverseAll.Name = "tsReverseAll";
            resources.ApplyResources(this.tsReverseAll, "tsReverseAll");
            this.tsReverseAll.Click += new System.EventHandler(this.tsReverseAll_Click);
            // 
            // tsReverseSelected
            // 
            this.tsReverseSelected.Name = "tsReverseSelected";
            resources.ApplyResources(this.tsReverseSelected, "tsReverseSelected");
            this.tsReverseSelected.Click += new System.EventHandler(this.tsReverseSelected_Click);
            // 
            // FDesktop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FDesktop";
            this.Closed += new System.EventHandler(this.FDesktop_Closed);
            this.Load += new System.EventHandler(this.FDesktop_Load);
            this.Shown += new System.EventHandler(this.FDesktop_Shown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private ThumbnailList thumbnailList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsProfiles;
        private System.Windows.Forms.ToolStripButton tsAbout;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton tsImport;
        private System.Windows.Forms.ToolStripDropDownButton tsdSavePDF;
        private System.Windows.Forms.ToolStripMenuItem tsSavePDFAll;
        private System.Windows.Forms.ToolStripMenuItem tsSavePDFSelected;
        private System.Windows.Forms.ToolStripDropDownButton tsdRotate;
        private System.Windows.Forms.ToolStripMenuItem tsRotateLeft;
        private System.Windows.Forms.ToolStripMenuItem tsRotateRight;
        private System.Windows.Forms.ToolStripMenuItem tsFlip;
        private System.Windows.Forms.ToolStripDropDownButton tsdReorder;
        private System.Windows.Forms.ToolStripMenuItem tsInterleave;
        private System.Windows.Forms.ToolStripMenuItem tsDeinterleave;
        private System.Windows.Forms.ToolStripDropDownButton tsdSaveImages;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImagesAll;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImagesSelected;
        private System.Windows.Forms.ToolStripDropDownButton tsdEmailPDF;
        private System.Windows.Forms.ToolStripMenuItem tsEmailPDFAll;
        private System.Windows.Forms.ToolStripMenuItem tsEmailPDFSelected;
        private System.Windows.Forms.ToolStripButton tsOcr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxView;
        private System.Windows.Forms.ToolStripMenuItem ctxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.Button btnQuickScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsReverse;
        private System.Windows.Forms.ToolStripMenuItem tsReverseAll;
        private System.Windows.Forms.ToolStripMenuItem tsReverseSelected;
    }
}
