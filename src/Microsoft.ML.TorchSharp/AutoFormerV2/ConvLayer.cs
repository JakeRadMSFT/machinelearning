﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using TorchSharp;
using TorchSharp.Modules;
using static TorchSharp.torch;
using static TorchSharp.torch.nn;

namespace Microsoft.ML.TorchSharp.AutoFormerV2
{
    /// <summary>
    /// The layer of convolution blocks in AutoFormer network.
    /// </summary>
    public class ConvLayer : Module<Tensor, int, int, (Tensor, int, int, Tensor, int, int)>
    {
        private readonly ModuleList<MBConv> blocks;
        private readonly PatchMerging downsample;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvLayer"/> class.
        /// </summary>
        /// <param name="inChannels">The input channels.</param>
        /// <param name="outChannels">The output channels.</param>
        /// <param name="depth">The number of blocks.</param>
        /// <param name="convExpandRatio">The expand ratio of convolution layer.</param>
        public ConvLayer(int inChannels, int outChannels, int depth, double convExpandRatio = 4.0)
            : base(nameof(ConvLayer))
        {
            this.blocks = new ModuleList<MBConv>();
            for (int i = 0; i < depth; i++)
            {
                this.blocks.Add(new MBConv(inChannels, inChannels, convExpandRatio));
            }

            this.downsample = new PatchMerging(inChannels, outChannels);
        }

        /// <inheritdoc/>
        public override (Tensor, int, int, Tensor, int, int) forward(Tensor x, int H, int W)
        {
            using (var scope = torch.NewDisposeScope())
            {
                foreach (var block in this.blocks)
                {
                    x = block.forward(x);
                }

                var xOut = x;
                var (xTmp, nH, nW) = this.downsample.forward(x, H, W);
                x = xTmp;

                return (xOut.MoveToOuterDisposeScope(), H, W, x.MoveToOuterDisposeScope(), nH, nW);
            }
        }
    }
}
