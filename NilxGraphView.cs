using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

namespace Nilx
{
    public class NilxGraphView : GraphView
    {
        public NilxGraphView()
        {
            styleSheets.Add(Resources.Load<StyleSheet>("NilxGraphView"));

            this.AddManipulator(new ContentDragger());
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());

            this.StretchToParentSize();

            var grid = new GridBackground();
            Insert(0, grid);
			grid.StretchToParentSize();
        }
    }
}
