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
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Ralms.EntityFrameworkCore.Oracle.Infrastructure.Internal
{
    public class OracleOptionsExtension : RelationalOptionsExtension
    {
        public OracleOptionsExtension()
        {
        }

        // NB: When adding new options, make sure to update the copy ctor below.

        protected OracleOptionsExtension([NotNull] OracleOptionsExtension copyFrom)
            : base(copyFrom)
        {
        }

        protected override RelationalOptionsExtension Clone()
            => new OracleOptionsExtension(this);

        public override bool ApplyServices(IServiceCollection services)
        {
            Check.NotNull(services, nameof(services));

            services.AddEntityFrameworkOracle();

            return true;
        }
    }
}
