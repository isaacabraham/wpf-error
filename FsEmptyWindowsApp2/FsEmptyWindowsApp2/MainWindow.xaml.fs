namespace ViewModels

open System
open System.Windows
open FSharp.ViewModule
open FSharp.ViewModule.Validation
open FsXaml

type MyConverter() =
    inherit ConverterBase(fun _ _ _ _ -> 10 :> obj)

type MainView = XAML<"MainWindow.xaml">

type MainViewModel() = 
    inherit ViewModelBase()