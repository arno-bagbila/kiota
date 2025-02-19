// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Lexis.Client.Models
{
    #pragma warning disable CS1591
    public class Blog : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The author property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Lexis.Client.Models.BlogAuthor? Author { get; set; }
#nullable restore
#else
        public Lexis.Client.Models.BlogAuthor Author { get; set; }
#endif
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>The createdOn property</summary>
        public DateTimeOffset? CreatedOn { get; private set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The publishedOn property</summary>
        public DateTimeOffset? PublishedOn { get; set; }
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Lexis.Client.Models.Blog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Lexis.Client.Models.Blog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Lexis.Client.Models.Blog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<Lexis.Client.Models.BlogAuthor>(Lexis.Client.Models.BlogAuthor.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "createdOn", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "publishedOn", n => { PublishedOn = n.GetDateTimeOffsetValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Lexis.Client.Models.BlogAuthor>("author", Author);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("publishedOn", PublishedOn);
            writer.WriteStringValue("text", Text);
        }
    }
}
