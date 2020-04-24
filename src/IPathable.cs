using System.Collections.Generic;

namespace Ladybug.Pathfinding
{
	public interface IPathable
	{
		List<IPathable> GetNeighbors();
		int GetDistanceEstimate(IPathable otherObject);
	}
}