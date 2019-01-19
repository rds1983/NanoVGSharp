﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NanoVGSharp
{
	public class FONStextIter
	{
		public float x;
		public float y;
		public float nextx;
		public float nexty;
		public float scale;
		public float spacing;
		public uint codepoint;
		public short isize;
		public short iblur;
		public FONSfont font;
		public int prevGlyphIndex;
		public StringLocation str, next;
		public int bitmapOption;
	}
}