﻿using System;
using System.Management.Automation;
using Haipa.ClientRuntime;
using Haipa.ComputeClient.Models;
using JetBrains.Annotations;

namespace Haipa.ComputeClient.Commands
{
    [PublicAPI]
    [Cmdlet(VerbsLifecycle.Start, "HaipaMachine")]
    [OutputType(typeof(Operation), typeof(Machine))]
    public class StartHaipaMachineCommand : ComputeCmdLet
    {
        [Parameter(
            Position = 0,
            ValueFromPipeline = true,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public Guid[] Id { get; set; }

        /// <summary>
        /// This parameter overrides the ShouldContinue call to force
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [Parameter]
        public SwitchParameter Force
        {
            get => _force;
            set => _force = value;
        }

        [Parameter]
        public SwitchParameter Wait
        {
            get => _wait;
            set => _wait = value;
        }

        private bool _force;
        private bool _wait;
        private bool _yesToAll, _noToAll;


        protected override void ProcessRecord()
        {
            foreach (var id in Id)
            {
                Machine machine;
                try
                {
                    machine = ComputeClient.Machines.Get(id);
                }
                catch (ApiServiceException ex)
                {
                    WriteError(new ErrorRecord(ex, "MachineNotFound", ErrorCategory.ObjectNotFound, id));
                    continue;
                }

                if (!Force && !ShouldContinue($"Machine '{machine.Name}' (Id:{id}) will be started!", "Warning!",
                    ref _yesToAll, ref _noToAll))
                {
                    continue;
                }

                WaitForOperation(ComputeClient.Machines.Start(id), _wait, false, id);

            }

        }

    }
}