using System.Collections.Generic;

namespace Pathfinding
{
    public class PathBuilder
    {
        public List<IPathfindingNode> path => _path;

        private List<IPathfindingNode> _path;
        private IPathfindingNode _currentNode;
        
        internal void ResetPath()
        {
            _path = new List<IPathfindingNode>();
        }

        internal void AddNodesToPath()
        {
            IPathfindingNode endNode = _currentNode;
            _path.Add(endNode);
            while (endNode.parent != null)
            {
                _path.Add(endNode.parent);
                endNode = endNode.parent;
            }
        }
    }
}