/* ========================================================================
 * Copyright (c) 2005-2013 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

// Copied from the OPC UA 1.02 samples

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;

namespace Opc.Ua
{
    #region ComplianceLevel Enumeration
    #if (!OPCUA_EXCLUDE_ComplianceLevel)
    /// <summary>
    /// A description for the ComplianceLevel DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Namespaces.OpcUaXsd)]
    public enum ComplianceLevel
    {
        /// <summary>
        /// A description for the Untested field.
        /// </summary>
        [EnumMember(Value = "Untested_0")]
        Untested = 0,

        /// <summary>
        /// A description for the Partial field.
        /// </summary>
        [EnumMember(Value = "Partial_1")]
        Partial = 1,

        /// <summary>
        /// A description for the SelfTested field.
        /// </summary>
        [EnumMember(Value = "SelfTested_2")]
        SelfTested = 2,

        /// <summary>
        /// A description for the Certified field.
        /// </summary>
        [EnumMember(Value = "Certified_3")]
        Certified = 3,
    }
    #endif
    #endregion

    #region SupportedProfile Class
    #if (!OPCUA_EXCLUDE_SupportedProfile)
    /// <summary>
    /// A description for the SupportedProfile DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Namespaces.OpcUaXsd)]
    public partial class SupportedProfile : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SupportedProfile()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_organizationUri = null;
            m_profileId = null;
            m_complianceTool = null;
            m_complianceDate = DateTime.MinValue;
            m_complianceLevel = ComplianceLevel.Untested;
            m_unsupportedUnitIds = new StringCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the OrganizationUri field.
        /// </summary>
        [DataMember(Name = "OrganizationUri", IsRequired = false, Order = 1)]
        public string OrganizationUri
        {
            get { return m_organizationUri;  }
            set { m_organizationUri = value; }
        }

        /// <summary>
        /// A description for the ProfileId field.
        /// </summary>
        [DataMember(Name = "ProfileId", IsRequired = false, Order = 2)]
        public string ProfileId
        {
            get { return m_profileId;  }
            set { m_profileId = value; }
        }

        /// <summary>
        /// A description for the ComplianceTool field.
        /// </summary>
        [DataMember(Name = "ComplianceTool", IsRequired = false, Order = 3)]
        public string ComplianceTool
        {
            get { return m_complianceTool;  }
            set { m_complianceTool = value; }
        }

        /// <summary>
        /// A description for the ComplianceDate field.
        /// </summary>
        [DataMember(Name = "ComplianceDate", IsRequired = false, Order = 4)]
        public DateTime ComplianceDate
        {
            get { return m_complianceDate;  }
            set { m_complianceDate = value; }
        }

        /// <summary>
        /// A description for the ComplianceLevel field.
        /// </summary>
        [DataMember(Name = "ComplianceLevel", IsRequired = false, Order = 5)]
        public ComplianceLevel ComplianceLevel
        {
            get { return m_complianceLevel;  }
            set { m_complianceLevel = value; }
        }

        /// <summary>
        /// A description for the UnsupportedUnitIds field.
        /// </summary>
        [DataMember(Name = "UnsupportedUnitIds", IsRequired = false, Order = 6)]
        public StringCollection UnsupportedUnitIds
        {
            get
            {
                return m_unsupportedUnitIds;
            }

            set
            {
                m_unsupportedUnitIds = value;

                if (value == null)
                {
                    m_unsupportedUnitIds = new StringCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return new NodeId(335u); }    // DataTypeIds.SupportedProfile
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return new NodeId(337u); }    // ObjectIds.SupportedProfile_Encoding_DefaultBinary
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return new NodeId(336u); }    // ObjectIds.SupportedProfile_Encoding_DefaultXml
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Namespaces.OpcUaXsd);

            encoder.WriteString("OrganizationUri", OrganizationUri);
            encoder.WriteString("ProfileId", ProfileId);
            encoder.WriteString("ComplianceTool", ComplianceTool);
            encoder.WriteDateTime("ComplianceDate", ComplianceDate);
            encoder.WriteEnumerated("ComplianceLevel", ComplianceLevel);
            encoder.WriteStringArray("UnsupportedUnitIds", UnsupportedUnitIds);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Namespaces.OpcUaXsd);

            OrganizationUri = decoder.ReadString("OrganizationUri");
            ProfileId = decoder.ReadString("ProfileId");
            ComplianceTool = decoder.ReadString("ComplianceTool");
            ComplianceDate = decoder.ReadDateTime("ComplianceDate");
            ComplianceLevel = (ComplianceLevel)decoder.ReadEnumerated("ComplianceLevel", typeof(ComplianceLevel));
            UnsupportedUnitIds = decoder.ReadStringArray("UnsupportedUnitIds");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SupportedProfile value = encodeable as SupportedProfile;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_organizationUri, value.m_organizationUri)) return false;
            if (!Utils.IsEqual(m_profileId, value.m_profileId)) return false;
            if (!Utils.IsEqual(m_complianceTool, value.m_complianceTool)) return false;
            if (!Utils.IsEqual(m_complianceDate, value.m_complianceDate)) return false;
            if (!Utils.IsEqual(m_complianceLevel, value.m_complianceLevel)) return false;
            if (!Utils.IsEqual(m_unsupportedUnitIds, value.m_unsupportedUnitIds)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            SupportedProfile clone = (SupportedProfile)this.MemberwiseClone();

            clone.m_organizationUri = (string)Utils.Clone(this.m_organizationUri);
            clone.m_profileId = (string)Utils.Clone(this.m_profileId);
            clone.m_complianceTool = (string)Utils.Clone(this.m_complianceTool);
            clone.m_complianceDate = (DateTime)Utils.Clone(this.m_complianceDate);
            clone.m_complianceLevel = (ComplianceLevel)Utils.Clone(this.m_complianceLevel);
            clone.m_unsupportedUnitIds = (StringCollection)Utils.Clone(this.m_unsupportedUnitIds);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_organizationUri;
        private string m_profileId;
        private string m_complianceTool;
        private DateTime m_complianceDate;
        private ComplianceLevel m_complianceLevel;
        private StringCollection m_unsupportedUnitIds;
        #endregion
    }

    #region SupportedProfileCollection Class
    /// <summary>
    /// A collection of SupportedProfile objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSupportedProfile", Namespace = Opc.Ua.Namespaces.OpcUaXsd, ItemName = "SupportedProfile")]
    public partial class SupportedProfileCollection : List<SupportedProfile>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SupportedProfileCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SupportedProfileCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SupportedProfileCollection(IEnumerable<SupportedProfile> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SupportedProfileCollection(SupportedProfile[] values)
        {
            if (values != null)
            {
                return new SupportedProfileCollection(values);
            }

            return new SupportedProfileCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SupportedProfile[](SupportedProfileCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            SupportedProfileCollection clone = new SupportedProfileCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SupportedProfile)Utils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region SoftwareCertificate Class
    #if (!OPCUA_EXCLUDE_SoftwareCertificate)
    /// <summary>
    /// A description for the SoftwareCertificate DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Namespaces.OpcUaXsd)]
    public partial class SoftwareCertificate : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SoftwareCertificate()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_productName = null;
            m_productUri = null;
            m_vendorName = null;
            m_vendorProductCertificate = null;
            m_softwareVersion = null;
            m_buildNumber = null;
            m_buildDate = DateTime.MinValue;
            m_issuedBy = null;
            m_issueDate = DateTime.MinValue;
            m_supportedProfiles = new SupportedProfileCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ProductName field.
        /// </summary>
        [DataMember(Name = "ProductName", IsRequired = false, Order = 1)]
        public string ProductName
        {
            get { return m_productName;  }
            set { m_productName = value; }
        }

        /// <summary>
        /// A description for the ProductUri field.
        /// </summary>
        [DataMember(Name = "ProductUri", IsRequired = false, Order = 2)]
        public string ProductUri
        {
            get { return m_productUri;  }
            set { m_productUri = value; }
        }

        /// <summary>
        /// A description for the VendorName field.
        /// </summary>
        [DataMember(Name = "VendorName", IsRequired = false, Order = 3)]
        public string VendorName
        {
            get { return m_vendorName;  }
            set { m_vendorName = value; }
        }

        /// <summary>
        /// A description for the VendorProductCertificate field.
        /// </summary>
        [DataMember(Name = "VendorProductCertificate", IsRequired = false, Order = 4)]
        public byte[] VendorProductCertificate
        {
            get { return m_vendorProductCertificate;  }
            set { m_vendorProductCertificate = value; }
        }

        /// <summary>
        /// A description for the SoftwareVersion field.
        /// </summary>
        [DataMember(Name = "SoftwareVersion", IsRequired = false, Order = 5)]
        public string SoftwareVersion
        {
            get { return m_softwareVersion;  }
            set { m_softwareVersion = value; }
        }

        /// <summary>
        /// A description for the BuildNumber field.
        /// </summary>
        [DataMember(Name = "BuildNumber", IsRequired = false, Order = 6)]
        public string BuildNumber
        {
            get { return m_buildNumber;  }
            set { m_buildNumber = value; }
        }

        /// <summary>
        /// A description for the BuildDate field.
        /// </summary>
        [DataMember(Name = "BuildDate", IsRequired = false, Order = 7)]
        public DateTime BuildDate
        {
            get { return m_buildDate;  }
            set { m_buildDate = value; }
        }

        /// <summary>
        /// A description for the IssuedBy field.
        /// </summary>
        [DataMember(Name = "IssuedBy", IsRequired = false, Order = 8)]
        public string IssuedBy
        {
            get { return m_issuedBy;  }
            set { m_issuedBy = value; }
        }

        /// <summary>
        /// A description for the IssueDate field.
        /// </summary>
        [DataMember(Name = "IssueDate", IsRequired = false, Order = 9)]
        public DateTime IssueDate
        {
            get { return m_issueDate;  }
            set { m_issueDate = value; }
        }

        /// <summary>
        /// A description for the SupportedProfiles field.
        /// </summary>
        [DataMember(Name = "SupportedProfiles", IsRequired = false, Order = 10)]
        public SupportedProfileCollection SupportedProfiles
        {
            get
            {
                return m_supportedProfiles;
            }

            set
            {
                m_supportedProfiles = value;

                if (value == null)
                {
                    m_supportedProfiles = new SupportedProfileCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return new NodeId(341u); }    // DataTypeIds.SoftwareCertificate
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return new NodeId(343u); }    // ObjectIds.SoftwareCertificate_Encoding_DefaultBinary
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return new NodeId(342u); }    // ObjectIds.SoftwareCertificate_Encoding_DefaultXml
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Namespaces.OpcUaXsd);

            encoder.WriteString("ProductName", ProductName);
            encoder.WriteString("ProductUri", ProductUri);
            encoder.WriteString("VendorName", VendorName);
            encoder.WriteByteString("VendorProductCertificate", VendorProductCertificate);
            encoder.WriteString("SoftwareVersion", SoftwareVersion);
            encoder.WriteString("BuildNumber", BuildNumber);
            encoder.WriteDateTime("BuildDate", BuildDate);
            encoder.WriteString("IssuedBy", IssuedBy);
            encoder.WriteDateTime("IssueDate", IssueDate);
            encoder.WriteEncodeableArray("SupportedProfiles", SupportedProfiles.ToArray(), typeof(SupportedProfile));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Namespaces.OpcUaXsd);

            ProductName = decoder.ReadString("ProductName");
            ProductUri = decoder.ReadString("ProductUri");
            VendorName = decoder.ReadString("VendorName");
            VendorProductCertificate = decoder.ReadByteString("VendorProductCertificate");
            SoftwareVersion = decoder.ReadString("SoftwareVersion");
            BuildNumber = decoder.ReadString("BuildNumber");
            BuildDate = decoder.ReadDateTime("BuildDate");
            IssuedBy = decoder.ReadString("IssuedBy");
            IssueDate = decoder.ReadDateTime("IssueDate");
            SupportedProfiles = (SupportedProfileCollection)decoder.ReadEncodeableArray("SupportedProfiles", typeof(SupportedProfile));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SoftwareCertificate value = encodeable as SoftwareCertificate;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_productName, value.m_productName)) return false;
            if (!Utils.IsEqual(m_productUri, value.m_productUri)) return false;
            if (!Utils.IsEqual(m_vendorName, value.m_vendorName)) return false;
            if (!Utils.IsEqual(m_vendorProductCertificate, value.m_vendorProductCertificate)) return false;
            if (!Utils.IsEqual(m_softwareVersion, value.m_softwareVersion)) return false;
            if (!Utils.IsEqual(m_buildNumber, value.m_buildNumber)) return false;
            if (!Utils.IsEqual(m_buildDate, value.m_buildDate)) return false;
            if (!Utils.IsEqual(m_issuedBy, value.m_issuedBy)) return false;
            if (!Utils.IsEqual(m_issueDate, value.m_issueDate)) return false;
            if (!Utils.IsEqual(m_supportedProfiles, value.m_supportedProfiles)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            SoftwareCertificate clone = (SoftwareCertificate)this.MemberwiseClone();

            clone.m_productName = (string)Utils.Clone(this.m_productName);
            clone.m_productUri = (string)Utils.Clone(this.m_productUri);
            clone.m_vendorName = (string)Utils.Clone(this.m_vendorName);
            clone.m_vendorProductCertificate = (byte[])Utils.Clone(this.m_vendorProductCertificate);
            clone.m_softwareVersion = (string)Utils.Clone(this.m_softwareVersion);
            clone.m_buildNumber = (string)Utils.Clone(this.m_buildNumber);
            clone.m_buildDate = (DateTime)Utils.Clone(this.m_buildDate);
            clone.m_issuedBy = (string)Utils.Clone(this.m_issuedBy);
            clone.m_issueDate = (DateTime)Utils.Clone(this.m_issueDate);
            clone.m_supportedProfiles = (SupportedProfileCollection)Utils.Clone(this.m_supportedProfiles);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_productName;
        private string m_productUri;
        private string m_vendorName;
        private byte[] m_vendorProductCertificate;
        private string m_softwareVersion;
        private string m_buildNumber;
        private DateTime m_buildDate;
        private string m_issuedBy;
        private DateTime m_issueDate;
        private SupportedProfileCollection m_supportedProfiles;
        #endregion
    }
    #endif
    #endregion
}