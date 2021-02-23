// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProjectServer/Authentication.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Unity.Reflect.ProjectServer.Services.Authentication {
  /// <summary>
  /// This service can be called anonymously
  /// </summary>
  public static partial class AuthenticationService
  {
    static readonly string __ServiceName = "Reflect.AuthenticationService";

    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Empty> __Marshaller_Reflect_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse> __Marshaller_Reflect_SigninResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest> __Marshaller_Reflect_PublicKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse> __Marshaller_Reflect_PublicKeyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest> __Marshaller_Reflect_ProjectAccessTokenRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse> __Marshaller_Reflect_ProjectAccessTokenResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Unity.Reflect.ProjectServer.Services.Empty, global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse> __Method_Signin = new grpc::Method<global::Unity.Reflect.ProjectServer.Services.Empty, global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Signin",
        __Marshaller_Reflect_Empty,
        __Marshaller_Reflect_SigninResponse);

    static readonly grpc::Method<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse> __Method_GetPublicKey = new grpc::Method<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPublicKey",
        __Marshaller_Reflect_PublicKeyRequest,
        __Marshaller_Reflect_PublicKeyResponse);

    static readonly grpc::Method<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse> __Method_GetProjectAccessToken = new grpc::Method<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProjectAccessToken",
        __Marshaller_Reflect_ProjectAccessTokenRequest,
        __Marshaller_Reflect_ProjectAccessTokenResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Unity.Reflect.ProjectServer.Services.Authentication.AuthenticationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AuthenticationService</summary>
    [grpc::BindServiceMethod(typeof(AuthenticationService), "BindService")]
    public abstract partial class AuthenticationServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse> Signin(global::Unity.Reflect.ProjectServer.Services.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse> GetPublicKey(global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse> GetProjectAccessToken(global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AuthenticationService</summary>
    public partial class AuthenticationServiceClient : grpc::ClientBase<AuthenticationServiceClient>
    {
      /// <summary>Creates a new client for AuthenticationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AuthenticationServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AuthenticationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AuthenticationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AuthenticationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AuthenticationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse Signin(global::Unity.Reflect.ProjectServer.Services.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Signin(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse Signin(global::Unity.Reflect.ProjectServer.Services.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Signin, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse> SigninAsync(global::Unity.Reflect.ProjectServer.Services.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SigninAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse> SigninAsync(global::Unity.Reflect.ProjectServer.Services.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Signin, null, options, request);
      }
      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse GetPublicKey(global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPublicKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse GetPublicKey(global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPublicKey, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse> GetPublicKeyAsync(global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPublicKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse> GetPublicKeyAsync(global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPublicKey, null, options, request);
      }
      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse GetProjectAccessToken(global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProjectAccessToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse GetProjectAccessToken(global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProjectAccessToken, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse> GetProjectAccessTokenAsync(global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProjectAccessTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse> GetProjectAccessTokenAsync(global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProjectAccessToken, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AuthenticationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AuthenticationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AuthenticationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Signin, serviceImpl.Signin)
          .AddMethod(__Method_GetPublicKey, serviceImpl.GetPublicKey)
          .AddMethod(__Method_GetProjectAccessToken, serviceImpl.GetProjectAccessToken).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AuthenticationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Signin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Unity.Reflect.ProjectServer.Services.Empty, global::Unity.Reflect.ProjectServer.Services.Authentication.SigninResponse>(serviceImpl.Signin));
      serviceBinder.AddMethod(__Method_GetPublicKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.PublicKeyResponse>(serviceImpl.GetPublicKey));
      serviceBinder.AddMethod(__Method_GetProjectAccessToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenRequest, global::Unity.Reflect.ProjectServer.Services.Authentication.ProjectAccessTokenResponse>(serviceImpl.GetProjectAccessToken));
    }

  }
}
#endregion
