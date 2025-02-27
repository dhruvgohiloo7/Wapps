﻿using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace Wapps.Forms.IOS
{
	public static class StringExtensions
	{
		/// <summary>
		/// Gets the height of a string.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <param name="font">The font.</param>
		/// <param name="width">The width.</param>
		/// <returns>nfloat.</returns>
		public static nfloat StringHeight (this string text, UIFont font, nfloat width)
		{
			return text.StringRect(font, width).Height;
		}

		/// <summary>
		/// To the native string.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns>NSString.</returns>
		public static NSString ToNativeString (this string text)
		{
			return new NSString(text);
		}

		/// <summary>
		/// Gets the rectangle of a string.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <param name="font">The font.</param>
		/// <param name="width">The width.</param>
		/// <returns>CGRect.</returns>
		public static CGRect StringRect(this string text, UIFont font, nfloat width)
		{
			return text.ToNativeString().GetBoundingRect(
				new CGSize(width, nfloat.MaxValue),
				NSStringDrawingOptions.OneShot,//.UsesFontLeading | NSStringDrawingOptions.UsesLineFragmentOrigin,
				new UIStringAttributes { Font = font },
				null);
		}

		/// <summary>
		/// Strings the size.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <param name="font">The font.</param>
		/// <returns>CGSize.</returns>
		public static CGSize StringSize(this string text, UIFont font)
		{
			return text.ToNativeString().GetSizeUsingAttributes(new UIStringAttributes { Font = font });
		}
	}
}

