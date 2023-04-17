using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGrid_to_TreeGrid
{
    public class TreeGridRowDragDropControllerExt : TreeGridRowDragDropController
    {
        public TreeGridRowDragDropControllerExt()
        {

        }

        protected override void ProcessDragSourceOnDrop(SfTreeGrid sourceTreeGrid, ObservableCollection<TreeNode> nodes)
        {
            //by default SfTreeGrid provide the support to move the item into one treegrid to another treegrid 
            //here we have customize the code snippets related to the Node
            //collection Moving function to copy function of One treegrid to another treegrid
            if (sourceTreeGrid == null || nodes == null)
            {
                return;
            }
        }
    }
}
