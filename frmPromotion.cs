using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ChessGame2.UserControls;


namespace ChessGame2.UserControls
{ 

public partial class frmPromotion : XtraForm
{

    public static ChessPieceType Type;

    public ChessPieceType PromotionType
    {
        get { return Type; }
        set { Type = value; }
    }

    public frmPromotion()
    {
        InitializeComponent();

    }

    public frmPromotion(Bitmap p1, Bitmap p2, Bitmap p3, Bitmap p4)
    {
        //Chuyển từ kiểu Bitmap sang kiểu Image


        InitializeComponent();
        pic1.Image = p1;
        pictureBox1.Image = p2;
        pictureBox2.Image = p3;
        pictureBox3.Image = p4;

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Type = ChessPieceType.Queen;
    }

    private void pic1_Click(object sender, EventArgs e)
    {
        Type = ChessPieceType.Queen;
        this.Close();
    }


    private void pictureBox1_Click(object sender, EventArgs e)
    {
        Type = ChessPieceType.Rook;
        this.Close();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Type = ChessPieceType.Knight;
        this.Close();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        Type = ChessPieceType.Bishop;
        this.Close();
    }

}
}