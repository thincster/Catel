﻿namespace Catel.Tests.Data
{
    using System;
    using System.Runtime.Serialization;
    using Catel.Data;

#if NET
    [Serializable]
#endif
    public class ClassWithoutPropertiesA : ComparableModelBase
    {
        #region Fields
        #endregion

        #region Constructors
        /// <summary>
        ///   Initializes a new object from scratch.
        /// </summary>
        public ClassWithoutPropertiesA()
        {
        }

#if NET
        /// <summary>
        ///   Initializes a new object based on <see cref = "SerializationInfo" />.
        /// </summary>
        /// <param name = "info"><see cref = "SerializationInfo" /> that contains the information.</param>
        /// <param name = "context"><see cref = "StreamingContext" />.</param>
        protected ClassWithoutPropertiesA(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion
    }
}