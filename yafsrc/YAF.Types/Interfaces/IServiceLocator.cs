/* Yet Another Forum.NET
 * Copyright (C) 2006-2010 Jaben Cargman
 * http://www.yetanotherforum.net/
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
namespace YAF.Types.Interfaces
{
  #region Using

  using System;

  #endregion

  /// <summary>
  /// The i service locator.
  /// </summary>
  public interface IServiceLocator
  {
    #region Public Methods

    /// <summary>
    /// The get.
    /// </summary>
    /// <param name="serviceType">
    /// The service type.
    /// </param>
    /// <returns>
    /// The get.
    /// </returns>
    object Get([NotNull] Type serviceType);

    /// <summary>
    /// The get.
    /// </summary>
    /// <param name="serviceType">
    /// The service type.
    /// </param>
    /// <param name="named">
    /// The named.
    /// </param>
    /// <returns>
    /// The get.
    /// </returns>
    object Get([NotNull] Type serviceType, [NotNull] string named);

    /// <summary>
    /// The try get.
    /// </summary>
    /// <param name="serviceType">
    /// The service type.
    /// </param>
    /// <returns>
    /// The try get.
    /// </returns>
    bool TryGet([NotNull] Type serviceType, out object instance);

    /// <summary>
    /// The try get.
    /// </summary>
    /// <param name="serviceType">
    /// The service type.
    /// </param>
    /// <param name="named">
    /// The named.
    /// </param>
    /// <returns>
    /// The try get.
    /// </returns>
    bool TryGet([NotNull] Type serviceType, [NotNull] string named, out object instance);

    #endregion
  }
}