// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using MinhaLoja.Client.Pedidos;
using MinhaLoja.Client.Produtos;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace MinhaLoja.Client
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LojaClient : BaseRequestBuilder
    {
        /// <summary>The pedidos property</summary>
        public global::MinhaLoja.Client.Pedidos.PedidosRequestBuilder Pedidos
        {
            get => new global::MinhaLoja.Client.Pedidos.PedidosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The produtos property</summary>
        public global::MinhaLoja.Client.Produtos.ProdutosRequestBuilder Produtos
        {
            get => new global::MinhaLoja.Client.Produtos.ProdutosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MinhaLoja.Client.LojaClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LojaClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.minhaloja.com/v1";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
