using System.Collections.Generic;
using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }

    //Count the total values of each piece on the board, positive for white, negative for black
    private int Evaluate(Board board)
    {
        //Piece value hash table
        var pieceValues = new Dictionary<PieceType, int>
        {
            { PieceType.Pawn, 1 },
            { PieceType.Knight, 3 },
            { PieceType.Bishop, 3 },
            { PieceType.Rook, 5 },
            { PieceType.Queen, 9 },
            { PieceType.King, 0 },
            { PieceType.None, 0}
        };

        if (board.IsInCheckmate())
        {
            return board.IsWhiteToMove ? int.MinValue : int.MaxValue;
        }
        if (board.IsDraw())
        {
            return 0;
        }
        int value = 0;
        for (int i = 0; i < 64; i++)
        {
            //Get the piece at the current square
            Piece piece = board.GetPiece(new Square);
            //If the piece is white, add its value to the total

        }
        return value;
    }
}