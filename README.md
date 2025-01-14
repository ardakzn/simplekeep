# SimpleKeep

**SimpleKeep** is a simple and flexible system that allows you to easily save and load your data in Unity projects. You can quickly perform data save and load operations using both synchronous and asynchronous methods.

## Features

- **Synchronous and Asynchronous Support**: Methods for both synchronous and asynchronous data saving and loading.
- **Easy Integration**: Simple and easy integration.
- **Flexible Structure**: Compatible with various data types.
- **Platform Compatibility**: Works on PC, mobile, and other platforms.
- **JSON Format**: Data is saved and loaded in JSON format.

## Installation

1. **Download Asset**: Download the asset from GitHub.
2. **Add to Your Project**: Drag the downloaded file named **"SimpleKeep"** into your Unity Editor to include the asset in your project.
3. **Ready to Use**: Start using the `SimpleKeep` script immediately.

You can reach .dll format this plugin by this [SimpleKeep Asset Store Link](https://assetstore.unity.com/packages/your-package-link)

## Usage Examples

### "Save" Method (Save Data)
```csharp
SaveLoadManager<MyDataClass>.Save("saveFile.json", myData);
```
### "Load" Method (Load Data)
```csharp
MyDataClass loadedData = SaveLoadManager<MyDataClass>.Load("saveFile.json");
```
### "AsyncSave" Method (Asyncronous Save Data)
```csharp
await SaveLoadManager<MyDataClass>.SaveAsync("saveFile.json", myData);
```
### "AsyncLoad" Method (Asyncronous Load Data)
```csharp
MyDataClass loadedDataAsync = await SaveLoadManager<MyDataClass>.LoadAsync("saveFile.json");
```

## Support

If you encounter any issues, please email us at [arda.kzn@gmail.com](mailto:arda.kzn@gmail.com) or visit the GitHub Issues page.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Version Information

**v1.0.0** - Initial release.