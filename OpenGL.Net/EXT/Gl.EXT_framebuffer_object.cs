
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;

		/// <summary>
		/// [GL] glBindRenderbufferEXT: Binding for glBindRenderbufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindRenderbufferEXT(RenderbufferTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferEXT != null, "pglBindRenderbufferEXT not implemented");
			Delegates.pglBindRenderbufferEXT((Int32)target, renderbuffer);
			LogCommand("glBindRenderbufferEXT", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glBindFramebufferEXT: Binding for glBindFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindFramebufferEXT(FramebufferTarget target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferEXT != null, "pglBindFramebufferEXT not implemented");
			Delegates.pglBindFramebufferEXT((Int32)target, framebuffer);
			LogCommand("glBindFramebufferEXT", null, target, framebuffer			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
			internal extern static void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_framebuffer_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBindRenderbufferEXT(Int32 target, UInt32 renderbuffer);

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[ThreadStatic]
			internal static glBindRenderbufferEXT pglBindRenderbufferEXT;

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBindFramebufferEXT(Int32 target, UInt32 framebuffer);

			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[ThreadStatic]
			internal static glBindFramebufferEXT pglBindFramebufferEXT;

		}
	}

}
