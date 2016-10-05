# Getting Started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (ThingSpaceConnectivityManagementAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the ThingSpaceConnectivityManagementAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

### 3. Add reference of the library project

In order to use the ThingSpaceConnectivityManagementAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` ThingSpaceConnectivityManagementAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```ThingSpaceConnectivityManagementAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=ThingSpace%20Connectivity%20Management%20API-CSharp&workspaceName=ThingSpaceConnectivityManagementAPI&projectName=ThingSpaceConnectivityManagementAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication and Initialization
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| apiKey | TODO: add a description |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string apiKey = "apiKey";

ThingSpaceConnectivityManagementAPIClient client = new ThingSpaceConnectivityManagementAPIClient(apiKey);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [SmsController](#sms_controller)
* [SessionController](#session_controller)
* [PlansController](#plans_controller)
* [LeadsController](#leads_controller)
* [GroupsController](#groups_controller)
* [DevicesController](#devices_controller)
* [CallbacksController](#callbacks_controller)

### <a name="sms_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SmsController") SmsController

#### Get singleton instance

The singleton instance of the ``` SmsController ``` class can be accessed from the API Client.

```csharp
ISmsController sms = client.Sms;
```

#### <a name="update_start_sms_callback_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SmsController.UpdateStartSmsCallbackUsingPUT") UpdateStartSmsCallbackUsingPUT

> Starts delivery of queued SMS messages for the specific account.


```csharp
Task<RestSuccessResponse> UpdateStartSmsCallbackUsingPUT(string aname, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| aname |  ``` Required ```  | Account name |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
string aname = "aname";
string vZM2MToken = "VZ-M2M-Token";

RestSuccessResponse result = await sms.UpdateStartSmsCallbackUsingPUT(aname, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="get_sms_messages_using_get"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SmsController.GetSmsMessagesUsingGET") GetSmsMessagesUsingGET

> Retrieves queued SMS messages sent by all M2M MC devices associated with an account.


```csharp
Task<SmsMessagesResponse> GetSmsMessagesUsingGET(string aname, string vZM2MToken, long? next = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| aname |  ``` Required ```  | Account name |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| next |  ``` Optional ```  | Continue the previous query from the URL in Location Header |


#### Example Usage

```csharp
string aname = "aname";
string vZM2MToken = "VZ-M2M-Token";
long? next = 180;

SmsMessagesResponse result = await sms.GetSmsMessagesUsingGET(aname, vZM2MToken, next);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_send_sms_message_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SmsController.CreateSendSmsMessageUsingPOST") CreateSendSmsMessageUsingPOST

> Sends an SMS message to one or more devices.


```csharp
Task<RequestResponse> CreateSendSmsMessageUsingPOST(SMSSendRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | SMS Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new SMSSendRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await sms.CreateSendSmsMessageUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="session_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SessionController") SessionController

#### Get singleton instance

The singleton instance of the ``` SessionController ``` class can be accessed from the API Client.

```csharp
ISessionController session = client.Session;
```

#### <a name="update_reset_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SessionController.UpdateResetUsingPUT") UpdateResetUsingPUT

> Returns a new, randomly generated password for the current username


```csharp
Task<SessionResetPasswordResponse> UpdateResetUsingPUT(SessionResetPasswordRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Current Password |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new SessionResetPasswordRequest();
string vZM2MToken = "VZ-M2M-Token";

SessionResetPasswordResponse result = await session.UpdateResetUsingPUT(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_logout_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SessionController.CreateLogoutUsingPOST") CreateLogoutUsingPOST

> Ends a Connectivity Management session.


```csharp
Task<LogOutRequest> CreateLogoutUsingPOST(string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";

LogOutRequest result = await session.CreateLogoutUsingPOST(vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_login_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.SessionController.CreateLoginUsingPOST") CreateLoginUsingPOST

> Initiates a Connectivity Management session and returns a session token required in subsequent API requests.


```csharp
Task<LogInResponse> CreateLoginUsingPOST(LogInRequest request = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Optional ```  | request |


#### Example Usage

```csharp
var request = new LogInRequest();

LogInResponse result = await session.CreateLoginUsingPOST(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="plans_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.PlansController") PlansController

#### Get singleton instance

The singleton instance of the ``` PlansController ``` class can be accessed from the API Client.

```csharp
IPlansController plans = client.Plans;
```

#### <a name="get_service_plan_list_using_get"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.PlansController.GetServicePlanListUsingGET") GetServicePlanListUsingGET

> Returns a list of all data service plans that are associated with a specified account.


```csharp
Task<List<ServicePlanResponse>> GetServicePlanListUsingGET(string vZM2MToken, string aname)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";

List<ServicePlanResponse> result = await plans.GetServicePlanListUsingGET(vZM2MToken, aname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="leads_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.LeadsController") LeadsController

#### Get singleton instance

The singleton instance of the ``` LeadsController ``` class can be accessed from the API Client.

```csharp
ILeadsController leads = client.Leads;
```

#### <a name="get_list_using_get1"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.LeadsController.GetListUsingGET1") GetListUsingGET1

> Returns information for all leads associated with the account


```csharp
Task<LeadInformationResponse> GetListUsingGET1(string vZM2MToken, string aname, long? next = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |
| next |  ``` Optional ```  | Continue the previous query from the pageUrl in Location Header |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";
long? next = 17;

LeadInformationResponse result = await leads.GetListUsingGET1(vZM2MToken, aname, next);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="groups_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController") GroupsController

#### Get singleton instance

The singleton instance of the ``` GroupsController ``` class can be accessed from the API Client.

```csharp
IGroupsController groups = client.Groups;
```

#### <a name="delete_device_group_using_delete"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController.DeleteDeviceGroupUsingDELETE") DeleteDeviceGroupUsingDELETE

> Deletes a device group. Devices in the group are moved to the default device group and are not deleted from the account.


```csharp
Task<RestSuccessResponse> DeleteDeviceGroupUsingDELETE(string vZM2MToken, string aname, string gname)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |
| gname |  ``` Required ```  | Group name |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";
string gname = "gname";

RestSuccessResponse result = await groups.DeleteDeviceGroupUsingDELETE(vZM2MToken, aname, gname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="update_device_group_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController.UpdateDeviceGroupUsingPUT") UpdateDeviceGroupUsingPUT

> Make changes to a device group, including changing the name and description, and adding or removing devices.


```csharp
Task<RestSuccessResponse> UpdateDeviceGroupUsingPUT(
        GroupUpdateRequest request,
        string aname,
        string gname,
        string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| aname |  ``` Required ```  | Account name |
| gname |  ``` Required ```  | Group name |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new GroupUpdateRequest();
string aname = "aname";
string gname = "gname";
string vZM2MToken = "VZ-M2M-Token";

RestSuccessResponse result = await groups.UpdateDeviceGroupUsingPUT(request, aname, gname, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="get_device_group_info_using_get"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController.GetDeviceGroupInfoUsingGET") GetDeviceGroupInfoUsingGET

> Returns the name, description, and list of devices in a device group.


```csharp
Task<GroupListResponse> GetDeviceGroupInfoUsingGET(
        string aname,
        string gname,
        string vZM2MToken,
        long? next = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| aname |  ``` Required ```  | Account name |
| gname |  ``` Required ```  | Group name |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| next |  ``` Optional ```  | Continue the previous query from the pageUrl pagetoken |


#### Example Usage

```csharp
string aname = "aname";
string gname = "gname";
string vZM2MToken = "VZ-M2M-Token";
long? next = 17;

GroupListResponse result = await groups.GetDeviceGroupInfoUsingGET(aname, gname, vZM2MToken, next);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="get_list_using_get"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController.GetListUsingGET") GetListUsingGET

> Returns a list of device groups in an account


```csharp
Task<List<GroupResponse>> GetListUsingGET(string vZM2MToken, string aname)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";

List<GroupResponse> result = await groups.GetListUsingGET(vZM2MToken, aname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_device_group_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.GroupsController.CreateDeviceGroupUsingPOST") CreateDeviceGroupUsingPOST

> Creates a new device group and optionally adds a set of devices to that group.


```csharp
Task<RestSuccessResponse> CreateDeviceGroupUsingPOST(CreateDevGroupRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CreateDevGroupRequest();
string vZM2MToken = "VZ-M2M-Token";

RestSuccessResponse result = await groups.CreateDeviceGroupUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="devices_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController") DevicesController

#### Get singleton instance

The singleton instance of the ``` DevicesController ``` class can be accessed from the API Client.

```csharp
IDevicesController devices = client.Devices;
```

#### <a name="change_device_id_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.ChangeDeviceIdUsingPUT") ChangeDeviceIdUsingPUT

> Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service.


```csharp
Task<RequestResponse> ChangeDeviceIdUsingPUT(string serviceType, ChangeDeviceIdRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| serviceType |  ``` Required ```  | Identifier type |
| request |  ``` Required ```  | Device Usage Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
string serviceType = "serviceType";
var request = new ChangeDeviceIdRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.ChangeDeviceIdUsingPUT(serviceType, request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_aggregate_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateAggregateUsingPOST") CreateAggregateUsingPOST

> Returns the total amount of data sent and the total number of SMS messages sent or received by a set of devices in a specified timeframe.


```csharp
Task<RequestResponse> CreateAggregateUsingPOST(DeviceAggregateUsageListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceAggregateUsageListRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreateAggregateUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_usage_list_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateUsageListUsingPOST") CreateUsageListUsingPOST

> Returns the network data usage history of a device during a specified time period.


```csharp
Task<List<DeviceUsageListResponse>> CreateUsageListUsingPOST(DeviceUsageListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device Usage Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceUsageListRequest();
string vZM2MToken = "VZ-M2M-Token";

List<DeviceUsageListResponse> result = await devices.CreateUsageListUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_prl_list_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreatePrlListUsingPOST") CreatePrlListUsingPOST

> Requests the current PRL version for devices, which can help determine which devices need a PRL update.


```csharp
Task<RequestResponse> CreatePrlListUsingPOST(DevicePrlListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device PRL Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DevicePrlListRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreatePrlListUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_provisioning_history_list_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateProvisioningHistoryListUsingPOST") CreateProvisioningHistoryListUsingPOST

> Returns the provisioning history of a device during a specified time period.


```csharp
Task<List<DeviceProvisioningHistoryListResponse>> CreateProvisioningHistoryListUsingPOST(DeviceProvisioningHistoryListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device ProHistory Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceProvisioningHistoryListRequest();
string vZM2MToken = "VZ-M2M-Token";

List<DeviceProvisioningHistoryListResponse> result = await devices.CreateProvisioningHistoryListUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="change_cost_center_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.ChangeCostCenterUsingPUT") ChangeCostCenterUsingPUT

> Changes or removes the costCenterCode value for one or more devices.


```csharp
Task<RequestResponse> ChangeCostCenterUsingPUT(DeviceCostCenterRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceCostCenterRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.ChangeCostCenterUsingPUT(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_connection_list_history_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateConnectionListHistoryUsingPOST") CreateConnectionListHistoryUsingPOST

> Returns a list of network connection events for a device during a specified time period.


```csharp
Task<List<ConnectionHistoryResponse>> CreateConnectionListHistoryUsingPOST(DeviceConnectionListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device Connection Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceConnectionListRequest();
string vZM2MToken = "VZ-M2M-Token";

List<ConnectionHistoryResponse> result = await devices.CreateConnectionListHistoryUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_connection_list_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateConnectionListUsingPOST") CreateConnectionListUsingPOST

> Returns a list of network connection events for a device during a specified time period.


```csharp
Task<List<ConnectionEvent>> CreateConnectionListUsingPOST(DeviceConnectionListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device Connection Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceConnectionListRequest();
string vZM2MToken = "VZ-M2M-Token";

List<ConnectionEvent> result = await devices.CreateConnectionListUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_restore_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateRestoreUsingPOST") CreateRestoreUsingPOST

> Restore service to one or more suspended devices. 


```csharp
Task<RequestResponse> CreateRestoreUsingPOST(CarrierActionsRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Update state |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CarrierActionsRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreateRestoreUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_suspend_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateSuspendUsingPOST") CreateSuspendUsingPOST

> Suspends service for one or more devices. 


```csharp
Task<RequestResponse> CreateSuspendUsingPOST(CarrierActionsRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Update state |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CarrierActionsRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreateSuspendUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="update_service_plan_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.UpdateServicePlanUsingPUT") UpdateServicePlanUsingPUT

> Sets a new service plan for one or more devices.


```csharp
Task<RequestResponse> UpdateServicePlanUsingPUT(ServicePlanUpdateRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new ServicePlanUpdateRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.UpdateServicePlanUsingPUT(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_list_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateListUsingPOST") CreateListUsingPOST

> Returns information about a specified device or a list of devices in an account.


```csharp
Task<DeviceListResponse> CreateListUsingPOST(DeviceListRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Device Query |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new DeviceListRequest();
string vZM2MToken = "VZ-M2M-Token";

DeviceListResponse result = await devices.CreateListUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_deactive_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateDeactiveUsingPOST") CreateDeactiveUsingPOST

> Deactivates service for one or more devices.


```csharp
Task<RequestResponse> CreateDeactiveUsingPOST(CarrierDeactivateRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Deactivate state |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CarrierDeactivateRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreateDeactiveUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="update_custom_fields_using_put"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.UpdateCustomFieldsUsingPUT") UpdateCustomFieldsUsingPUT

> Updates one or more custom field values for devices.


```csharp
Task<RequestResponse> UpdateCustomFieldsUsingPUT(CustomFieldsUpdateRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Request |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CustomFieldsUpdateRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.UpdateCustomFieldsUsingPUT(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="add_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.AddUsingPOST") AddUsingPOST

> Adds up to 200 new devices, without provisioning lines of service for them.


```csharp
Task<List<AddDevicesResponseMessage>> AddUsingPOST(AddDevicesRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Devices to Add |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new AddDevicesRequest();
string vZM2MToken = "VZ-M2M-Token";

List<AddDevicesResponseMessage> result = await devices.AddUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_active_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.DevicesController.CreateActiveUsingPOST") CreateActiveUsingPOST

> Activates service for one or more devices.


```csharp
Task<RequestResponse> CreateActiveUsingPOST(CarrierActivateRequest request, string vZM2MToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | Activate state |
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |


#### Example Usage

```csharp
var request = new CarrierActivateRequest();
string vZM2MToken = "VZ-M2M-Token";

RequestResponse result = await devices.CreateActiveUsingPOST(request, vZM2MToken);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)

### <a name="callbacks_controller"></a>![Class: ](http://apidocs.io/img/class.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.CallbacksController") CallbacksController

#### Get singleton instance

The singleton instance of the ``` CallbacksController ``` class can be accessed from the API Client.

```csharp
ICallbacksController callbacks = client.Callbacks;
```

#### <a name="delete_unregister_callback_using_delete"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.CallbacksController.DeleteUnregisterCallbackUsingDELETE") DeleteUnregisterCallbackUsingDELETE

> Stops the platform from sending callback messages for the specified account and service.


```csharp
Task<CallbackActionResponse> DeleteUnregisterCallbackUsingDELETE(string vZM2MToken, string aname, string sname)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |
| sname |  ``` Required ```  | Service name |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";
string sname = "sname";

CallbackActionResponse result = await callbacks.DeleteUnregisterCallbackUsingDELETE(vZM2MToken, aname, sname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="create_register_callback_using_post"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.CallbacksController.CreateRegisterCallbackUsingPOST") CreateRegisterCallbackUsingPOST

> Registers a URL where an account will receive RESTFul messages from a platform callback service.


```csharp
Task<CallbackActionResponse> CreateRegisterCallbackUsingPOST(string vZM2MToken, string aname, RegisterCallbackRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |
| request |  ``` Required ```  | Request |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";
var request = new RegisterCallbackRequest();

CallbackActionResponse result = await callbacks.CreateRegisterCallbackUsingPOST(vZM2MToken, aname, request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


#### <a name="list_callbacks_using_get"></a>![Method: ](http://apidocs.io/img/method.png "ThingSpaceConnectivityManagementAPI.PCL.Controllers.CallbacksController.ListCallbacksUsingGET") ListCallbacksUsingGET

> Returns the name and endpoint URL of all callback listening services registered for a given account.


```csharp
Task<List<Callback>> ListCallbacksUsingGET(string vZM2MToken, string aname)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| vZM2MToken |  ``` Required ```  | M2M-MC Session Token |
| aname |  ``` Required ```  | Account name |


#### Example Usage

```csharp
string vZM2MToken = "VZ-M2M-Token";
string aname = "aname";

List<Callback> result = await callbacks.ListCallbacksUsingGET(vZM2MToken, aname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error Response |


[Back to List of Controllers](#list_of_controllers)



