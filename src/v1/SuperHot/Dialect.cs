// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace SuperHot
{
	/// <summary>
	/// Dialects (instruction set versions) of the SuperH processors
	/// </summary>
	public enum Dialect
	{
		Unknown = 0,

		/// <summary>
		/// SH-1 instruction set
		/// <remarks>
		/// used in Sega Saturn's CD controller
		/// </remarks>
		/// </summary>
		Sh,

		/// <summary>
		/// SH-2 instruction set
		/// <remarks>
		/// used in Sega Saturn's dual CPUs
		/// </remarks>
		/// </summary>
		Sh2,

		/// <summary>
		/// SH-2A instruction set
		/// <remarks>
		/// used in automotive
		/// </remarks>
		/// </summary>
		Sh2a,

		/// <summary>
		/// SH-2E instruction set
		/// <remarks>
		/// used in multimedia
		/// </remarks>
		/// </summary>
		Sh2e,

		/// <summary>
		/// SH-3 instruction set
		/// <remarks>
		/// used in HP Jornada (Pocket PC) series
		/// </remarks>
		/// </summary>
		Sh3,

		/// <summary>
		/// SH-3E instruction set
		/// <remarks>
		/// used in multimedia
		/// </remarks>
		/// </summary>
		Sh3e,

		/// <summary>
		/// SH-4 instruction set
		/// <remarks>
		/// used in Sega Dreamcast's main CPU
		/// </remarks>
		/// </summary>
		Sh4,

		/// <summary>
		/// SH-4A instruction set
		/// <remarks>
		/// used in automotive
		/// </remarks>
		/// </summary>
		Sh4a
	}
}