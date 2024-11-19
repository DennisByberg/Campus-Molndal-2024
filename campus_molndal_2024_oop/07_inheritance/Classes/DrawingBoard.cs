using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class DrawingBoard
    {
        List<IDrawable> drawingBoard = new List<IDrawable>();

        public void AddDrawing(IDrawable drawing)
        {
            drawingBoard.Add(drawing);
        }

        public void DisplayAll()
        {
            foreach (var drawing in drawingBoard)
            {
                drawing.Draw();
            }
        }
    }
}
