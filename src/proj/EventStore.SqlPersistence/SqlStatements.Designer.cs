﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventStore.SqlPersistence {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.SqlPersistence.SqlStatements", typeof(SqlStatements).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Commits
        ///   SET Snapshot = @Payload
        /// WHERE StreamId = @StreamId
        ///   AND Sequence = @Sequence;.
        /// </summary>
        internal static string AppendSnapshotToCommit {
            get {
                return ResourceManager.GetString("AppendSnapshotToCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT StreamId, CommitId, Revision, Sequence, Payload, Snapshot
        ///  FROM Commits
        /// WHERE StreamId = @StreamId
        ///   AND @Revision BETWEEN 
        ///     ( SELECT MAX(Revision)
        ///         FROM Commits
        ///        WHERE StreamId = @StreamId
        ///          AND Revision &lt;= @Revision
        ///          AND Snapshot IS NOT NULL ) AND Revision;.
        /// </summary>
        internal static string GetCommitsFromSnapshotUntilRevision {
            get {
                return ResourceManager.GetString("GetCommitsFromSnapshotUntilRevision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT StreamId, CommitId, Revision, Sequence, Payload, null
        ///  FROM Commits
        /// WHERE StreamId = @StreamId
        ///   AND Revision &gt;= @Revision;.
        /// </summary>
        internal static string GetCommitsFromStartingRevision {
            get {
                return ResourceManager.GetString("GetCommitsFromStartingRevision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT StreamId
        ///  FROM Streams
        /// WHERE HeadRevision &gt;= SnapshotRevision + @Threshold;.
        /// </summary>
        internal static string GetStreamsRequiringSnaphots {
            get {
                return ResourceManager.GetString("GetStreamsRequiringSnaphots", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT C.StreamId, C.CommitId, C.Revision, C.Sequence, C.Payload, null
        ///  FROM Commits AS C
        /// INNER JOIN Dispatch AS D
        ///    ON C.StreamId = D.StreamId
        ///   AND C.Sequence = D.Sequence;.
        /// </summary>
        internal static string GetUndispatchedCommits {
            get {
                return ResourceManager.GetString("GetUndispatchedCommits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE
        ///  FROM Dispatch
        /// WHERE StreamId = @StreamId
        ///   AND Sequence = @Sequence;.
        /// </summary>
        internal static string MarkCommitAsDispatched {
            get {
                return ResourceManager.GetString("MarkCommitAsDispatched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN TRANSACTION;
        ///
        ///INSERT
        ///  INTO Streams
        ///     ( StreamId, Name, HeadRevision )
        ///SELECT @StreamId, @StreamName, @Revision
        /// WHERE @OldRevision = 0;
        ///
        ///UPDATE Streams
        ///   SET HeadRevision = @Revision
        ///  FROM Streams
        /// WHERE StreamId = @StreamId
        ///   AND HeadRevision = @OldRevision
        ///   AND @OldRevision &gt; 0;
        ///
        ///INSERT
        ///  INTO Commits
        ///     ( StreamId, Sequence, CommitId, Revision, Payload )
        ///SELECT @StreamId, @Sequence, @CommitId, @Revision, @Payload
        /// WHERE NOT EXISTS
        ///     ( SELECT *
        ///         FROM Commit [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PersistCommitAttempt {
            get {
                return ResourceManager.GetString("PersistCommitAttempt", resourceCulture);
            }
        }
    }
}