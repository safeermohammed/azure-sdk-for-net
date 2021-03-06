// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Hyak.Common.Internals;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search
{
    /// <summary>
    /// Client that can be used to manage and query indexes and documents on an
    /// Azure Search service.  (see
    /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
    /// information)
    /// </summary>
    public partial class SearchServiceClient : ServiceClient<SearchServiceClient>, ISearchServiceClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SearchCredentials _credentials;
        
        /// <summary>
        /// Gets or sets the credentials used to authenticate to an Azure
        /// Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </summary>
        public SearchCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _searchServiceName;
        
        /// <summary>
        /// Gets or sets the name of the Azure Search service.
        /// </summary>
        public string SearchServiceName
        {
            get { return this._searchServiceName; }
            set { this._searchServiceName = value; }
        }
        
        private IIndexOperations _indexes;
        
        /// <summary>
        /// Operations for managing indexes.  (see
        /// https://msdn.microsoft.com/library/azure/dn798918.aspx for more
        /// information)
        /// </summary>
        public virtual IIndexOperations Indexes
        {
            get { return this._indexes; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        public SearchServiceClient()
            : base()
        {
            this._indexes = new IndexOperations(this);
            this._apiVersion = "2015-02-28";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        /// <param name='searchServiceName'>
        /// Required. Gets or sets the name of the Azure Search service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets or sets the credentials used to authenticate to an
        /// Azure Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public SearchServiceClient(string searchServiceName, SearchCredentials credentials, Uri baseUri)
            : this()
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException("searchServiceName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._searchServiceName = searchServiceName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        /// <param name='searchServiceName'>
        /// Required. Gets or sets the name of the Azure Search service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets or sets the credentials used to authenticate to an
        /// Azure Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </param>
        public SearchServiceClient(string searchServiceName, SearchCredentials credentials)
            : this()
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException("searchServiceName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._searchServiceName = searchServiceName;
            this._credentials = credentials;
            this._baseUri = TypeConversion.TryParseUri("https://" + this.SearchServiceName + ".search.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SearchServiceClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._indexes = new IndexOperations(this);
            this._apiVersion = "2015-02-28";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        /// <param name='searchServiceName'>
        /// Required. Gets or sets the name of the Azure Search service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets or sets the credentials used to authenticate to an
        /// Azure Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SearchServiceClient(string searchServiceName, SearchCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException("searchServiceName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._searchServiceName = searchServiceName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchServiceClient class.
        /// </summary>
        /// <param name='searchServiceName'>
        /// Required. Gets or sets the name of the Azure Search service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets or sets the credentials used to authenticate to an
        /// Azure Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SearchServiceClient(string searchServiceName, SearchCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException("searchServiceName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._searchServiceName = searchServiceName;
            this._credentials = credentials;
            this._baseUri = TypeConversion.TryParseUri("https://" + this.SearchServiceName + ".search.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// SearchServiceClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of SearchServiceClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<SearchServiceClient> client)
        {
            base.Clone(client);
            
            if (client is SearchServiceClient)
            {
                SearchServiceClient clonedClient = ((SearchServiceClient)client);
                
                clonedClient._searchServiceName = this._searchServiceName;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type IndexActionType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static IndexActionType ParseIndexActionType(string value)
        {
            if ("upload".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return IndexActionType.Upload;
            }
            if ("merge".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return IndexActionType.Merge;
            }
            if ("mergeOrUpload".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return IndexActionType.MergeOrUpload;
            }
            if ("delete".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return IndexActionType.Delete;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type IndexActionType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string IndexActionTypeToString(IndexActionType value)
        {
            if (value == IndexActionType.Upload)
            {
                return "upload";
            }
            if (value == IndexActionType.Merge)
            {
                return "merge";
            }
            if (value == IndexActionType.MergeOrUpload)
            {
                return "mergeOrUpload";
            }
            if (value == IndexActionType.Delete)
            {
                return "delete";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type ScoringFunctionAggregation.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static ScoringFunctionAggregation ParseScoringFunctionAggregation(string value)
        {
            if ("sum".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionAggregation.Sum;
            }
            if ("average".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionAggregation.Average;
            }
            if ("minimum".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionAggregation.Minimum;
            }
            if ("maximum".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionAggregation.Maximum;
            }
            if ("firstMatching".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionAggregation.FirstMatching;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type ScoringFunctionAggregation to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string ScoringFunctionAggregationToString(ScoringFunctionAggregation value)
        {
            if (value == ScoringFunctionAggregation.Sum)
            {
                return "sum";
            }
            if (value == ScoringFunctionAggregation.Average)
            {
                return "average";
            }
            if (value == ScoringFunctionAggregation.Minimum)
            {
                return "minimum";
            }
            if (value == ScoringFunctionAggregation.Maximum)
            {
                return "maximum";
            }
            if (value == ScoringFunctionAggregation.FirstMatching)
            {
                return "firstMatching";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type ScoringFunctionInterpolation.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static ScoringFunctionInterpolation ParseScoringFunctionInterpolation(string value)
        {
            if ("linear".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionInterpolation.Linear;
            }
            if ("constant".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionInterpolation.Constant;
            }
            if ("quadratic".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionInterpolation.Quadratic;
            }
            if ("logarithmic".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return ScoringFunctionInterpolation.Logarithmic;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type ScoringFunctionInterpolation to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string ScoringFunctionInterpolationToString(ScoringFunctionInterpolation value)
        {
            if (value == ScoringFunctionInterpolation.Linear)
            {
                return "linear";
            }
            if (value == ScoringFunctionInterpolation.Constant)
            {
                return "constant";
            }
            if (value == ScoringFunctionInterpolation.Quadratic)
            {
                return "quadratic";
            }
            if (value == ScoringFunctionInterpolation.Logarithmic)
            {
                return "logarithmic";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type SearchMode.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static SearchMode ParseSearchMode(string value)
        {
            if ("any".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return SearchMode.Any;
            }
            if ("all".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return SearchMode.All;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type SearchMode to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string SearchModeToString(SearchMode value)
        {
            if (value == SearchMode.Any)
            {
                return "any";
            }
            if (value == SearchMode.All)
            {
                return "all";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type SuggesterSearchMode.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static SuggesterSearchMode ParseSuggesterSearchMode(string value)
        {
            if ("analyzingInfixMatching".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return SuggesterSearchMode.AnalyzingInfixMatching;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type SuggesterSearchMode to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string SuggesterSearchModeToString(SuggesterSearchMode value)
        {
            if (value == SuggesterSearchMode.AnalyzingInfixMatching)
            {
                return "analyzingInfixMatching";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
