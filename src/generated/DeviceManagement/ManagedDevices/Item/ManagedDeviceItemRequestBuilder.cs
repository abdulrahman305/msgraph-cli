// <auto-generated/>
using ApiSdk.DeviceManagement.ManagedDevices.Item.BypassActivationLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.CleanWindowsDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCategory;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCompliancePolicyStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceConfigurationStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DisableLostMode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LocateDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LogCollectionRequests;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RebootNow;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RecoverPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RemoteLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RequestRemoteAssistance;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ResetPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Retire;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ShutDown;
using ApiSdk.DeviceManagement.ManagedDevices.Item.SyncDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Users;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderScan;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsProtectionState;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Wipe;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.DeviceManagement.ManagedDevices.Item
{
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class ManagedDeviceItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to call the bypassActivationLock method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBypassActivationLockNavCommand()
        {
            var command = new Command("bypass-activation-lock");
            command.Description = "Provides operations to call the bypassActivationLock method.";
            var builder = new BypassActivationLockRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the cleanWindowsDevice method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCleanWindowsDeviceNavCommand()
        {
            var command = new Command("clean-windows-device");
            command.Description = "Provides operations to call the cleanWindowsDevice method.";
            var builder = new CleanWindowsDeviceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Deletes a managedDevice.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-devices-manageddevice-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Deletes a managedDevice.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-devices-manageddevice-delete?view=graph-rest-1.0";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the deleteUserFromSharedAppleDevice method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteUserFromSharedAppleDeviceNavCommand()
        {
            var command = new Command("delete-user-from-shared-apple-device");
            command.Description = "Provides operations to call the deleteUserFromSharedAppleDevice method.";
            var builder = new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeviceCategoryNavCommand()
        {
            var command = new Command("device-category");
            command.Description = "Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceCategoryRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeviceCompliancePolicyStatesNavCommand()
        {
            var command = new Command("device-compliance-policy-states");
            command.Description = "Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceCompliancePolicyStatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeviceConfigurationStatesNavCommand()
        {
            var command = new Command("device-configuration-states");
            command.Description = "Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.";
            var builder = new DeviceConfigurationStatesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the disableLostMode method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDisableLostModeNavCommand()
        {
            var command = new Command("disable-lost-mode");
            command.Description = "Provides operations to call the disableLostMode method.";
            var builder = new DisableLostModeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The list of managed devices.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The list of managed devices.";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the locateDevice method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLocateDeviceNavCommand()
        {
            var command = new Command("locate-device");
            command.Description = "Provides operations to call the locateDevice method.";
            var builder = new LocateDeviceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLogCollectionRequestsNavCommand()
        {
            var command = new Command("log-collection-requests");
            command.Description = "Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.";
            var builder = new LogCollectionRequestsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the logoutSharedAppleDeviceActiveUser method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLogoutSharedAppleDeviceActiveUserNavCommand()
        {
            var command = new Command("logout-shared-apple-device-active-user");
            command.Description = "Provides operations to call the logoutSharedAppleDeviceActiveUser method.";
            var builder = new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property managedDevices in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property managedDevices in deviceManagement";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the rebootNow method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRebootNowNavCommand()
        {
            var command = new Command("reboot-now");
            command.Description = "Provides operations to call the rebootNow method.";
            var builder = new RebootNowRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the recoverPasscode method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRecoverPasscodeNavCommand()
        {
            var command = new Command("recover-passcode");
            command.Description = "Provides operations to call the recoverPasscode method.";
            var builder = new RecoverPasscodeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the remoteLock method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRemoteLockNavCommand()
        {
            var command = new Command("remote-lock");
            command.Description = "Provides operations to call the remoteLock method.";
            var builder = new RemoteLockRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the requestRemoteAssistance method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRequestRemoteAssistanceNavCommand()
        {
            var command = new Command("request-remote-assistance");
            command.Description = "Provides operations to call the requestRemoteAssistance method.";
            var builder = new RequestRemoteAssistanceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the resetPasscode method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResetPasscodeNavCommand()
        {
            var command = new Command("reset-passcode");
            command.Description = "Provides operations to call the resetPasscode method.";
            var builder = new ResetPasscodeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the retire method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRetireNavCommand()
        {
            var command = new Command("retire");
            command.Description = "Provides operations to call the retire method.";
            var builder = new RetireRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the shutDown method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildShutDownNavCommand()
        {
            var command = new Command("shut-down");
            command.Description = "Provides operations to call the shutDown method.";
            var builder = new ShutDownRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the syncDevice method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSyncDeviceNavCommand()
        {
            var command = new Command("sync-device");
            command.Description = "Provides operations to call the syncDevice method.";
            var builder = new SyncDeviceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the updateWindowsDeviceAccount method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUpdateWindowsDeviceAccountNavCommand()
        {
            var command = new Command("update-windows-device-account");
            command.Description = "Provides operations to call the updateWindowsDeviceAccount method.";
            var builder = new UpdateWindowsDeviceAccountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the users property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUsersNavCommand()
        {
            var command = new Command("users");
            command.Description = "Provides operations to manage the users property of the microsoft.graph.managedDevice entity.";
            var builder = new UsersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the windowsDefenderScan method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWindowsDefenderScanNavCommand()
        {
            var command = new Command("windows-defender-scan");
            command.Description = "Provides operations to call the windowsDefenderScan method.";
            var builder = new WindowsDefenderScanRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the windowsDefenderUpdateSignatures method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWindowsDefenderUpdateSignaturesNavCommand()
        {
            var command = new Command("windows-defender-update-signatures");
            command.Description = "Provides operations to call the windowsDefenderUpdateSignatures method.";
            var builder = new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWindowsProtectionStateNavCommand()
        {
            var command = new Command("windows-protection-state");
            command.Description = "Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.";
            var builder = new WindowsProtectionStateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            nonExecCommands.Add(builder.BuildDetectedMalwareStateNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the wipe method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWipeNavCommand()
        {
            var command = new Command("wipe");
            command.Description = "Provides operations to call the wipe method.";
            var builder = new WipeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ManagedDeviceItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a managedDevice.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The list of managed devices.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The list of managed devices.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
