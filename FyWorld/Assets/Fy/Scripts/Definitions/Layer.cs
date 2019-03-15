/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
| FyWorld - A top down simulation game in a fantasy medieval world.    |
|                                                                      |
|    :copyright: © 2019 Florian Gasquez.                               |
|    :license: GPLv3, see LICENSE for more details.                    |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
namespace Fy.Definitions {
	// Grahpic Layer / Altitude for our tilables.
	[System.Serializable]
	public enum Layer : ushort {
		Undefined, // This is used if we don't want a grahpic representation.
		Ground, // Ground layer.
		Count // Count is just a nice trick to get the enum length.
	}
}