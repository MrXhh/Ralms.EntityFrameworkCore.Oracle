/* This project came from a fork of: https://github.com/aspnet/EntityFrameworkCore
 * Copyright (c) .NET Foundation. All rights reserved.
 * Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 * 
 *          Copyright (c)  2018 Rafael Almeida (ralms@ralms.net)
 *
 *                    Ralms.EntityFrameworkCore.Oracle
 *
 * THIS MATERIAL IS PROVIDED AS IS, WITH ABSOLUTELY NO WARRANTY EXPRESSED
 * OR IMPLIED.  ANY USE IS AT YOUR OWN RISK.
 *
 * Permission is hereby granted to use or copy this program
 * for any purpose,  provided the above notices are retained on all copies.
 * Permission to modify the code and to distribute modified code is granted,
 * provided the above notices are retained, and a notice that the code was
 * modified is included with the above copyright notice.
 *
 */

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Ralms.EntityFrameworkCore.Oracle.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Ralms.EntityFrameworkCore.Oracle.ValueGeneration.Internal
{
    public interface IOracleSequenceValueGeneratorFactory
    {
        ValueGenerator Create(
            [NotNull] IProperty property,
            [NotNull] OracleSequenceValueGeneratorState generatorState,
            [NotNull] IOracleConnection connection);
    }
}
