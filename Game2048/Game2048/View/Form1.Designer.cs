
namespace Game2048
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Board = new System.Windows.Forms.Panel();
            this.Field33 = new System.Windows.Forms.Label();
            this.Field32 = new System.Windows.Forms.Label();
            this.Field31 = new System.Windows.Forms.Label();
            this.Field30 = new System.Windows.Forms.Label();
            this.Field23 = new System.Windows.Forms.Label();
            this.Field22 = new System.Windows.Forms.Label();
            this.Field21 = new System.Windows.Forms.Label();
            this.Field20 = new System.Windows.Forms.Label();
            this.Field13 = new System.Windows.Forms.Label();
            this.Field12 = new System.Windows.Forms.Label();
            this.Field11 = new System.Windows.Forms.Label();
            this.Field10 = new System.Windows.Forms.Label();
            this.Field03 = new System.Windows.Forms.Label();
            this.Field02 = new System.Windows.Forms.Label();
            this.Field01 = new System.Windows.Forms.Label();
            this.Field00 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Board.Controls.Add(this.Field33);
            this.Board.Controls.Add(this.Field32);
            this.Board.Controls.Add(this.Field31);
            this.Board.Controls.Add(this.Field30);
            this.Board.Controls.Add(this.Field23);
            this.Board.Controls.Add(this.Field22);
            this.Board.Controls.Add(this.Field21);
            this.Board.Controls.Add(this.Field20);
            this.Board.Controls.Add(this.Field13);
            this.Board.Controls.Add(this.Field12);
            this.Board.Controls.Add(this.Field11);
            this.Board.Controls.Add(this.Field10);
            this.Board.Controls.Add(this.Field03);
            this.Board.Controls.Add(this.Field02);
            this.Board.Controls.Add(this.Field01);
            this.Board.Controls.Add(this.Field00);
            this.Board.Controls.Add(this.label1);
            this.Board.Location = new System.Drawing.Point(9, 85);
            this.Board.Margin = new System.Windows.Forms.Padding(2);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(188, 203);
            this.Board.TabIndex = 0;
            // 
            // Field33
            // 
            this.Field33.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field33.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field33.Location = new System.Drawing.Point(142, 154);
            this.Field33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field33.Name = "Field33";
            this.Field33.Size = new System.Drawing.Size(38, 41);
            this.Field33.TabIndex = 15;
            this.Field33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field32
            // 
            this.Field32.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field32.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field32.Location = new System.Drawing.Point(98, 154);
            this.Field32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field32.Name = "Field32";
            this.Field32.Size = new System.Drawing.Size(38, 41);
            this.Field32.TabIndex = 14;
            this.Field32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field31
            // 
            this.Field31.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field31.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field31.Location = new System.Drawing.Point(52, 154);
            this.Field31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field31.Name = "Field31";
            this.Field31.Size = new System.Drawing.Size(38, 41);
            this.Field31.TabIndex = 13;
            this.Field31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field30
            // 
            this.Field30.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field30.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field30.Location = new System.Drawing.Point(8, 154);
            this.Field30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field30.Name = "Field30";
            this.Field30.Size = new System.Drawing.Size(38, 41);
            this.Field30.TabIndex = 12;
            this.Field30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field23
            // 
            this.Field23.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field23.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field23.Location = new System.Drawing.Point(142, 106);
            this.Field23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field23.Name = "Field23";
            this.Field23.Size = new System.Drawing.Size(38, 41);
            this.Field23.TabIndex = 10;
            this.Field23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field22
            // 
            this.Field22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field22.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field22.Location = new System.Drawing.Point(98, 106);
            this.Field22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field22.Name = "Field22";
            this.Field22.Size = new System.Drawing.Size(38, 41);
            this.Field22.TabIndex = 9;
            this.Field22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field21
            // 
            this.Field21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field21.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field21.Location = new System.Drawing.Point(52, 106);
            this.Field21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field21.Name = "Field21";
            this.Field21.Size = new System.Drawing.Size(38, 41);
            this.Field21.TabIndex = 11;
            this.Field21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field20
            // 
            this.Field20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field20.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field20.Location = new System.Drawing.Point(8, 106);
            this.Field20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field20.Name = "Field20";
            this.Field20.Size = new System.Drawing.Size(38, 41);
            this.Field20.TabIndex = 8;
            this.Field20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field13
            // 
            this.Field13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field13.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field13.Location = new System.Drawing.Point(142, 57);
            this.Field13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field13.Name = "Field13";
            this.Field13.Size = new System.Drawing.Size(38, 41);
            this.Field13.TabIndex = 7;
            this.Field13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field12
            // 
            this.Field12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field12.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field12.Location = new System.Drawing.Point(98, 57);
            this.Field12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field12.Name = "Field12";
            this.Field12.Size = new System.Drawing.Size(38, 41);
            this.Field12.TabIndex = 6;
            this.Field12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field11
            // 
            this.Field11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field11.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field11.Location = new System.Drawing.Point(52, 57);
            this.Field11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field11.Name = "Field11";
            this.Field11.Size = new System.Drawing.Size(38, 41);
            this.Field11.TabIndex = 5;
            this.Field11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field10
            // 
            this.Field10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field10.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field10.Location = new System.Drawing.Point(8, 57);
            this.Field10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field10.Name = "Field10";
            this.Field10.Size = new System.Drawing.Size(38, 41);
            this.Field10.TabIndex = 2;
            this.Field10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field03
            // 
            this.Field03.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field03.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field03.Location = new System.Drawing.Point(142, 8);
            this.Field03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field03.Name = "Field03";
            this.Field03.Size = new System.Drawing.Size(38, 41);
            this.Field03.TabIndex = 4;
            this.Field03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field02
            // 
            this.Field02.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field02.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field02.Location = new System.Drawing.Point(98, 8);
            this.Field02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field02.Name = "Field02";
            this.Field02.Size = new System.Drawing.Size(38, 41);
            this.Field02.TabIndex = 3;
            this.Field02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field01
            // 
            this.Field01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field01.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field01.Location = new System.Drawing.Point(52, 8);
            this.Field01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field01.Name = "Field01";
            this.Field01.Size = new System.Drawing.Size(38, 41);
            this.Field01.TabIndex = 2;
            this.Field01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Field00
            // 
            this.Field00.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Field00.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field00.Location = new System.Drawing.Point(8, 8);
            this.Field00.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Field00.Name = "Field00";
            this.Field00.Size = new System.Drawing.Size(38, 41);
            this.Field00.TabIndex = 1;
            this.Field00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(36, 40);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(69, 22);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newGame.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(214, 28);
            this.newGame.Margin = new System.Windows.Forms.Padding(2);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(135, 49);
            this.newGame.TabIndex = 2;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.left.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Location = new System.Drawing.Point(206, 164);
            this.left.Margin = new System.Windows.Forms.Padding(2);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(49, 32);
            this.left.TabIndex = 3;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.up.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.Location = new System.Drawing.Point(258, 142);
            this.up.Margin = new System.Windows.Forms.Padding(2);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(49, 32);
            this.up.TabIndex = 4;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.right.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.Location = new System.Drawing.Point(310, 164);
            this.right.Margin = new System.Windows.Forms.Padding(2);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(49, 32);
            this.right.TabIndex = 5;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.down.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.Location = new System.Drawing.Point(258, 180);
            this.down.Margin = new System.Windows.Forms.Padding(2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(49, 32);
            this.down.TabIndex = 6;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(99, 40);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(75, 24);
            this.score.TabIndex = 7;
            this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 298);
            this.Controls.Add(this.score);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.up);
            this.Controls.Add(this.left);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Board);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Board.ResumeLayout(false);
            this.Board.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Field00;
        private System.Windows.Forms.Label Field30;
        private System.Windows.Forms.Label Field21;
        private System.Windows.Forms.Label Field23;
        private System.Windows.Forms.Label Field22;
        private System.Windows.Forms.Label Field20;
        private System.Windows.Forms.Label Field13;
        private System.Windows.Forms.Label Field12;
        private System.Windows.Forms.Label Field11;
        private System.Windows.Forms.Label Field10;
        private System.Windows.Forms.Label Field03;
        private System.Windows.Forms.Label Field02;
        private System.Windows.Forms.Label Field01;
        private System.Windows.Forms.Label Field33;
        private System.Windows.Forms.Label Field32;
        private System.Windows.Forms.Label Field31;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Label score;
    }
}

