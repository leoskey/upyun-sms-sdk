# upyun-sms-sdk
又拍云短信服务平台接口.NET C# SDK

## 使用

将这个生成DLL文件引用进你的项目。对了，无论如何，你还得引用Newtonsoft.Json这个玩意儿弄进的项目。
```csharp
using UpyunSMSSDK;
using UpyunSMSSDK.Model;
```
在[Upyun](https://sms.upyun.com/settings)上获取你的Token，它很关键。然后，实例化一个UpyunSMSClient对象。
```csharp
var token = "***********************";
var client = new UpyunSMSClient(token);
```

### 发送短信
实例化一个message对象，参数为：接收手机号码、模板Id（你得有审核通过的模板）、短信参数（多个参数以“|”分割）。
```csharp
var message = new Message("18888888888", "78", "1|注册");
var messageResult = client.SendMessages(message);
```

现在messageResult里面包含了接口返回的信息，通过这些信息再进行你下一步操作。

### 获取短信报表
```csharp
var messageReport = new MessageReport();
var messageReportResult = client.GetMessagesReport(messageReport);
```

## 确定短信是否发送成功
在返回的对象中，包含着```StatusCode```和```error_code```这两个属性,```StatusCode```是枚举类型```HttpStatusCode```:
```csharp
var result = client.SendMessages(message);
if ( result.StatusCode == HttpStatusCode.OK && error_code != null ) {
    // 发送成功
} else {
    // 发送失败
    // result.error_code和result.message包含着错误信息。
}
```

## 提示
在解决方案中有实际操作例子。
