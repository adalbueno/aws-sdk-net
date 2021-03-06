/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFolder operation.
    /// Updates the specified attributes of the specified folder. The user must have access
    /// to both the folder and its parent folder, if applicable.
    /// </summary>
    public partial class UpdateFolderRequest : AmazonWorkDocsRequest
    {
        private string _folderId;
        private string _name;
        private string _parentFolderId;
        private ResourceStateType _resourceState;

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        public string FolderId
        {
            get { return this._folderId; }
            set { this._folderId = value; }
        }

        // Check to see if FolderId property is set
        internal bool IsSetFolderId()
        {
            return this._folderId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the folder.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        public string ParentFolderId
        {
            get { return this._parentFolderId; }
            set { this._parentFolderId = value; }
        }

        // Check to see if ParentFolderId property is set
        internal bool IsSetParentFolderId()
        {
            return this._parentFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// The resource state of the folder. Note that only ACTIVE and RECYCLED are accepted
        /// values from the API.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState
        {
            get { return this._resourceState; }
            set { this._resourceState = value; }
        }

        // Check to see if ResourceState property is set
        internal bool IsSetResourceState()
        {
            return this._resourceState != null;
        }

    }
}