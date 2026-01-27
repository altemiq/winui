// -----------------------------------------------------------------------
// <copyright file="ViewStateChangedEventArgs.cs" company="Altemiq">
// Copyright (c) Altemiq. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Altemiq.WinUI.Controls;

/// <summary>
/// The <see cref="ListDetailsViewState"/> changed <see cref="EventArgs"/>.
/// </summary>
public class ViewStateChangedEventArgs : System.EventArgs
{
    /// <summary>
    /// Gets the view state.
    /// </summary>
    public required ListDetailsViewState ViewState { get; init; }
}