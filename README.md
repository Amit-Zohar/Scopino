# Scopino
## Arduino Oscilloscope
### Oscilloscope application for Arduino & .NET.
#### Features
- Sampling 2 analog channels
- Volt/Div = 0.1÷0.5V (input voltage 0÷5V)
- Time/Div = 1÷100msec (max. sampling rate 50KHz)
- Rising/Falling/Both trigger & level adjust
- Single/repetitive trigger
- Click & drag mouse on screen to measure
- D2 outputs 1KHz square wave (100Hz in version 1)

[Application screenshots](https://drive.google.com/drive/folders/1JHs0LscehpshJasrQ62X1ALa4K6F6C8z?usp=sharing)

#### Instructions
- Connect Arduino to the USB
- Uncheck "Unblock" checkbox in file Scope\Form1.resx properties (general tab)
- Compile and run the project
- Select the Arduino COM port

#### Wiring
- Channel 1 = Arduino A0 (analog 0 input)
- Channel 2 = Arduino A1 (analog 1 input)
- D2 outputs 1KHz 0÷5V square wave (can be connected to A0/A1)
