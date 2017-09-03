﻿
// Copyright (C) 2015-2017 Luca Piccioni
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

using System;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Replaces the source code in a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the handle of the shader object whose source code is to be replaced.
		/// </param>
		/// <param name="string">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void ShaderSource(UInt32 shader, String[] @string)
		{
			Int32[] length = new Int32[@string.Length];

			for (int i = 0; i < @string.Length; i++)
				length[i] = @string[i] != null ? @string[i].Length : 0;

			ShaderSource(shader, @string, length);
		}
	}
}
