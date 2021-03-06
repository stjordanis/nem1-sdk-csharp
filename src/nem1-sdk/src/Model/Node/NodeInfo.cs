﻿using io.nem1.sdk.Model.Blockchain;

namespace io.nem1.sdk.Model.Node
{
    /// <summary>
    /// Class NodeInfo.
    /// </summary>
    public class NodeInfo
    {
        /// <summary>
        /// Gets the features.
        /// </summary>
        /// <value>The features.</value>
        public int Features { get; }
        /// <summary>
        /// Gets the application.
        /// </summary>
        /// <value>The application.</value>
        public string Application { get; }
        /// <summary>
        /// Gets the network.
        /// </summary>
        /// <value>The network.</value>
        public NetworkType.Types Network { get; }
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get; }
        /// <summary>
        /// Gets the platform.
        /// </summary>
        /// <value>The platform.</value>
        public string Platform { get; }
        /// <summary>
        /// Gets the protocol.
        /// </summary>
        /// <value>The protocol.</value>
        public string Protocol { get; }
        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>The port.</value>
        public string Port { get; }
        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        public string Host { get; }
        /// <summary>
        /// Gets the public key.
        /// </summary>
        /// <value>The public key.</value>
        public string PublicKey { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfo"/> class.
        /// </summary>
        /// <param name="features">The features.</param>
        /// <param name="application">The application.</param>
        /// <param name="network">The network.</param>
        /// <param name="version">The version.</param>
        /// <param name="platform">The platform.</param>
        /// <param name="protocol">The protocol.</param>
        /// <param name="port">The port.</param>
        /// <param name="host">The host.</param>
        /// <param name="publicKey">The public key.</param>
        /// <param name="name">The name.</param>
        public NodeInfo(int features, string application, NetworkType.Types network, string version, string platform, string protocol, string port, string host, string publicKey, string name)
        {
            Features = features;
            Application = application;
            Network = network;
            Version = version;
            Platform = platform;
            Protocol = protocol;
            Port = port;
            Host = host;
            PublicKey = publicKey;
            Name = name;
        }

       
    }
}
