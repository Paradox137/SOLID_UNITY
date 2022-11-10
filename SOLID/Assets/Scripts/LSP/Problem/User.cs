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

            //! quad area = 25
            rectangle.Width = 5;
            
            //! quad area = 4
            rectangle.Height = 2;
            Debug.Assert(rectangle.Area() == 10);
        }
    }
}