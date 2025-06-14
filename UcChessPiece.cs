using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using ChessGame2.UserControls;
using DevExpress.XtraEditors;

namespace ChessGame2.UserControls
{
    public partial class UcChessPiece : XtraUserControl
    {
        ChessSide _side;
        ChessPieceType _type;
        ChessPieceStyle _style;
        int _positionX, _positionY; // Position of the piece on the board
        int _cellSize;
        int _pieceSize;
        Bitmap _image;
        Point _currentMousePos, _lastMousePos;
        UcChessCell _ucOnCell;

        public ChessSide Side
        {
            get => _side;
            set => _side = value;
        }

        public ChessPieceType Type
        {
            get => _type;
            set => _type = value;
        }

        public ChessPieceStyle Style
        {
            get => _style;
            set => _style = value;
        }

        public Bitmap Image
        {
            get => _image;
            set
            {
                this._image = value;
                Image.GetThumbnailImageAbort callback = null;
                IntPtr callbackdata = new IntPtr();
                this._image = (Bitmap)_image.GetThumbnailImage(_pieceSize, _pieceSize, callback, callbackdata);
                this.UpdateStyles();
            }
        }

        public int PositionX
        {
            get => _positionX;
            set => _positionX = value;
        }

        public int PositionY
        {
            get => _positionY;
            set => _positionY = value;
        }

        public int PieceSize
        {
            get => _pieceSize;
            set => _pieceSize = value;
        }

        public int CellSize
        {
            get => _cellSize;
            set => _cellSize = value;
        }

        public UcChessCell UConCell
        {
            get => _ucOnCell;
            set => _ucOnCell = value;
        }

        public UcChessPiece(int side, int type, int style, int cellSize, int pieceSize)
        {
            InitializeComponent();
            _side = (ChessSide)side;
            _type = (ChessPieceType)type;
            _style = (ChessPieceStyle)style;
            _cellSize = cellSize;
            _pieceSize = pieceSize;
            _image = clsImageProcess.GetChessPieceBitMap(_side, _type, _style);
            Size = new Size(_pieceSize, _pieceSize);
        }

        public UcChessPiece()
        {
            InitializeComponent();
        }

        public UcChessPiece(ChessSide side, ChessPieceType type, ChessPieceStyle style, int cellSize, int pieceSize)
        {
            InitializeComponent();
            _side = side;
            _type = type;
            _style = style;
            _cellSize = cellSize;
            _pieceSize = pieceSize;
            _image = clsImageProcess.GetChessPieceBitMap(_side, _type, _style);
            Size = new Size(_pieceSize, _pieceSize);
        }

        public UcChessPiece(ChessSide side, ChessPieceType type, ChessPieceStyle style, int cellSize, int pieceSize, int positionX, int positionY, UcChessCell ucOnCell)
        {
            InitializeComponent();
            _side = side;
            _type = type;
            _style = style;
            _cellSize = cellSize;
            _pieceSize = pieceSize;
            _positionX = positionX;
            _positionY = positionY;
            _ucOnCell = ucOnCell;
            _image = clsImageProcess.GetChessPieceBitMap(_side, _type, _style);
            Size = new Size(_pieceSize, _pieceSize);
        }

        public UcChessPiece(Bitmap bmpImage, int cellSize, int pieceSize)
        {
            InitializeComponent();
            _image = bmpImage;
            _cellSize = cellSize;
            _pieceSize = pieceSize;
            Size = new Size(_pieceSize, _pieceSize);
        }

        private void UcChessPiece_Load(object sender, EventArgs e)
        {
            // Set control styles for optimized painting
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            // Resize the image if it exists

            Image.GetThumbnailImageAbort callback = null;
            IntPtr callbackdata = new IntPtr();
            _image = (Bitmap)_image.GetThumbnailImage(Width, Height, callback, callbackdata);



            UpdateStyles();
            Invalidate(); // Ensure the control repaints after loading
        }

        private void UcChessPiece_MouseDown(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;

            _lastMousePos = MousePosition;
            UcChessBoard board = (UcChessBoard)Parent;

            board.arrMove = new ArrayList();
            // Highlight possible moves
            if ((board.OwnSide == Side || board.GameMode == GameMode.VsHuman) && board.GameStatus == GameStatus.NowPlaying)
            {
                if ((board.WhiteToMove && Side == ChessSide.White) || (!board.WhiteToMove && Side == ChessSide.Black))
                {
                    int[,] boardState = board._BoardState;
                    Point curPos = new Point(_positionX, _positionY);
                    board.arrMove = clsChessEngine.FindAllLegalMove(boardState, curPos, _type);
                    board.HighlightPossibleMoves();
                }
            }
        }

        private void UcChessPiece_MouseMove(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;

            BringToFront();
            Cursor = Cursors.Hand;
            UcChessBoard board = (UcChessBoard)Parent;

            if (Side == board.OwnSide || board.GameMode == GameMode.VsHuman)
            {
                if ((Side == ChessSide.White && board.WhiteToMove) || (Side == ChessSide.Black && !board.WhiteToMove))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        _currentMousePos = MousePosition;
                        int deltaX = _currentMousePos.X - _lastMousePos.X;
                        int deltaY = _currentMousePos.Y - _lastMousePos.Y;
                        Point newPos = new Point(Location.X + deltaX, Location.Y + deltaY);

                        // Prevent moving the piece outside the board
                        if (newPos.X < 0)
                        {
                            newPos = new Point(0, newPos.Y);
                            Cursor.Position = _lastMousePos;
                            return;
                        }
                        if (newPos.Y < 0)
                        {
                            newPos = new Point(newPos.X, 0);
                            Cursor.Position = _lastMousePos;
                            return;
                        }
                        if (newPos.X + Width > Parent.Width)
                        {
                            newPos = new Point(Parent.Width - Width, newPos.Y);
                            Cursor.Position = _lastMousePos;
                            return;
                        }
                        if (newPos.Y + Height > Parent.Height)
                        {
                            newPos = new Point(newPos.X, Parent.Height - Height);
                            Cursor.Position = _lastMousePos;
                            return;
                        }

                        Location = newPos;
                        _lastMousePos = _currentMousePos;
                    }
                    else
                    {
                        Cursor = Cursors.Hand;
                    }
                }
            }
        }

        private void UcChessPiece_MouseUp(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;

            UcChessBoard board = (UcChessBoard)Parent;
            if (Side == board.OwnSide || board.GameMode == GameMode.VsHuman)
            {
                if ((Side == ChessSide.White && board.WhiteToMove) || (Side == ChessSide.Black && !board.WhiteToMove))
                {
                    board.UnHighlightMoves();
                    // Calculate the new cell position based on the piece's center
                    int newX = (Location.X + (_pieceSize / 2)) / _cellSize;
                    int newY = (Location.Y + (_pieceSize / 2)) / _cellSize;

                    int newPosX, newPosY;
                    if (board.OwnSide == ChessSide.White)
                    {
                        newPosX = newX + 1;
                        newPosY = 8 - newY;
                    }
                    else
                    {
                        newPosX = 8 - newX;
                        newPosY = newY + 1;
                    }

                    Point newPos = new Point(newPosX, newPosY);
                    Point curPos = new Point(_positionX, _positionY);
                    board.DoMove(this, new clsMove(curPos, newPos));
                }
            }
        }

       private void UcChessPiece_Paint(object sender , PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(_image, new Rectangle(0, 0, _image.Width, _image.Height), 0, 0, _image.Width, _image.Height, GraphicsUnit.Pixel);
        }
    }
}