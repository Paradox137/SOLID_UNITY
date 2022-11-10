using UnityEngine;

namespace Core.LSP.Problem
{
    public class User : MonoBehaviour
    {
        void Start()
        {
            Rectangle rectangle = new Rectangle();
            
            //! PROBLEM CANT DO THIS
            //! Rectangle rectangle = new Square();

            rectangle.Width = 5;
            rectangle.Height = 2;
            Debug.Assert(rectangle.Area() == 10);
        }
    }
}