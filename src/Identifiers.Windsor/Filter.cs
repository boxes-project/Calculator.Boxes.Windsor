using Boxes.Integration.Setup.Filters;

namespace Identifiers.Windsor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Boxes;

    public class Filter : ITypeRegistrationFilter
    {
        public IEnumerable<Type> FilterTypes(Package package)
        {
            return Enumerable.Empty<Type>();
        }
    }
}