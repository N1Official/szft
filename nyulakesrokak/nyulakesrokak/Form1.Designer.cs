
namespace nyulakesrokak
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.leiras = new System.Windows.Forms.Label();
            this.tajekoztato = new System.Windows.Forms.Label();
            this.korokszama = new System.Windows.Forms.Label();
            this.nyul = new System.Windows.Forms.RadioButton();
            this.roka = new System.Windows.Forms.RadioButton();
            this.figyelmezteto = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(762, 188);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(762, 232);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            // 
            // kilepes
            // 
            this.kilepes.Location = new System.Drawing.Point(762, 278);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(75, 23);
            this.kilepes.TabIndex = 2;
            this.kilepes.Text = "Kilépés";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // leiras
            // 
            this.leiras.Location = new System.Drawing.Point(660, 35);
            this.leiras.Name = "leiras";
            this.leiras.Size = new System.Drawing.Size(274, 97);
            this.leiras.TabIndex = 6;
            this.leiras.Text = resources.GetString("leiras.Text");
            this.leiras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tajekoztato
            // 
            this.tajekoztato.AutoSize = true;
            this.tajekoztato.Location = new System.Drawing.Point(750, 149);
            this.tajekoztato.Name = "tajekoztato";
            this.tajekoztato.Size = new System.Drawing.Size(71, 13);
            this.tajekoztato.TabIndex = 7;
            this.tajekoztato.Text = "Körök száma:";
            // 
            // korokszama
            // 
            this.korokszama.AutoSize = true;
            this.korokszama.Location = new System.Drawing.Point(827, 149);
            this.korokszama.Name = "korokszama";
            this.korokszama.Size = new System.Drawing.Size(13, 13);
            this.korokszama.TabIndex = 8;
            this.korokszama.Text = "0";
            // 
            // nyul
            // 
            this.nyul.Image = global::nyulakesrokak.Properties.Resources.nyul1;
            this.nyul.Location = new System.Drawing.Point(808, 334);
            this.nyul.Name = "nyul";
            this.nyul.Size = new System.Drawing.Size(126, 89);
            this.nyul.TabIndex = 9;
            this.nyul.TabStop = true;
            this.nyul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nyul.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.nyul.UseVisualStyleBackColor = false;
            this.nyul.CheckedChanged += new System.EventHandler(this.nyul_CheckedChanged);
            // 
            // roka
            // 
            this.roka.Image = global::nyulakesrokak.Properties.Resources.roka1;
            this.roka.Location = new System.Drawing.Point(663, 334);
            this.roka.Name = "roka";
            this.roka.Size = new System.Drawing.Size(126, 89);
            this.roka.TabIndex = 10;
            this.roka.TabStop = true;
            this.roka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roka.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.roka.UseVisualStyleBackColor = false;
            this.roka.CheckedChanged += new System.EventHandler(this.roka_CheckedChanged);
            // 
            // figyelmezteto
            // 
            this.figyelmezteto.Location = new System.Drawing.Point(714, 192);
            this.figyelmezteto.Name = "figyelmezteto";
            this.figyelmezteto.Size = new System.Drawing.Size(171, 60);
            this.figyelmezteto.TabIndex = 0;
            this.figyelmezteto.Text = "Ahhoz hogy lásd a táblát, először ki kell jelölnöd valamelyik állatot!";
            this.figyelmezteto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabla
            // 
            this.tabla.ColumnCount = 10;
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.Location = new System.Drawing.Point(12, 12);
            this.tabla.Name = "tabla";
            this.tabla.RowCount = 10;
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabla.Size = new System.Drawing.Size(599, 411);
            this.tabla.TabIndex = 3;
            this.tabla.Visible = false;
            this.tabla.Paint += new System.Windows.Forms.PaintEventHandler(this.tabla_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 447);
            this.Controls.Add(this.figyelmezteto);
            this.Controls.Add(this.roka);
            this.Controls.Add(this.nyul);
            this.Controls.Add(this.korokszama);
            this.Controls.Add(this.tajekoztato);
            this.Controls.Add(this.leiras);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Nyulak és rókák - Dao László";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.Label leiras;
        private System.Windows.Forms.Label tajekoztato;
        private System.Windows.Forms.Label korokszama;
        private System.Windows.Forms.RadioButton nyul;
        private System.Windows.Forms.RadioButton roka;
        private System.Windows.Forms.Label figyelmezteto;
        private System.Windows.Forms.TableLayoutPanel tabla;
    }
}

