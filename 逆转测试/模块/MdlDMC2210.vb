Option Explicit On

Module MdlDMC2210






    '雷赛DMC2210.dll
    Declare Function d2210_board_init Lib "DMC2210.dll" () As Short  '初始化控制卡

    Declare Sub d2210_board_close Lib "DMC2210.dll" ()  '释放控制卡

    Declare Sub d2210_set_pulse_outmode Lib "DMC2210.dll" (ByVal axis As Short, ByVal outmode As Short)  '脉冲模式设置

    Declare Sub d2210_counter_config Lib "DMC2210.dll" (ByVal axis As Short, ByVal mode As Short)  '设置编码器输入口的计数方式
    ''' <summary>
    ''' 设置梯形速度曲线
    ''' </summary>
    ''' <param name="axis" >轴号</param>
    ''' <param name="Min_Vel"></param>
    ''' <param name="Max_Vel"></param>
    ''' <param name="Tacc"></param>
    ''' <param name="Tdec"></param>
    Declare Sub d2210_set_profile Lib "DMC2210.dll" (ByVal axis As Short, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double)  '设置梯形速度曲线

    Declare Sub d2210_set_s_profile Lib "DMC2210.dll" (ByVal axis As Short, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double, ByVal Sacc As Integer, ByVal Sdec As Integer)  '设置Ｓ形速度曲线（按S 段脉冲）

    Declare Sub d2210_set_st_profile Lib "DMC2210.dll" (ByVal axis As Short, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double, ByVal Tsacc As Double, ByVal Tsdec As Double)  '设置Ｓ形速度曲线（按 S 段时间）

    Declare Sub d2210_imd_stop Lib "DMC2210.dll" (ByVal axis As Short)  '单轴立即停止

    Declare Sub d2210_emg_stop Lib "DMC2210.dll" ()  '紧急停止所有轴

    Declare Sub d2210_t_pmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal Dist As Integer, ByVal posi_mode As Short)  '单轴梯形定长运动（对称的T 形加减速）

    Declare Sub d2210_ex_t_pmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal Dist As Integer, ByVal posi_mode As Short)  '单轴梯形定长运动（非对称的T 形加减速）

    Declare Sub d2210_s_pmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal Dist As Integer, ByVal posi_mode As Short)  '单轴S 形定长运动（对称的S 形加减速）

    Declare Sub d2210_ex_s_pmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal Dist As Integer, ByVal posi_mode As Short)  '单轴S 形定长运动（非对称的S 形加减速）

    Declare Sub d2210_s_vmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal dir As Short)  '单轴Ｓ形加速连续运动

    Declare Sub d2210_t_vmove Lib "DMC2210.dll" (ByVal axis As Short, ByVal dir As Short)  '单轴梯形加速连续运动

    Declare Sub d2210_config_home_mode Lib "DMC2210.dll" (ByVal axis As Short, ByVal mode As Short, ByVal EZ_count As Short)  '设置回原点模式

    Declare Sub d2210_home_move Lib "DMC2210.dll" (ByVal axis As Short, ByVal home_mode As Short, ByVal vel_mode As Short)  '启动回原点运动

    Declare Function d2210_check_done Lib "DMC2210.dll" (ByVal axis As Short) As Short  '读取指定轴的运动状态

    Declare Sub d2210_write_SEVON_PIN Lib "DMC2210.dll" (ByVal axis As Short, ByVal on_off As Short)  '输出SEVON 信号

    Declare Function d2210_get_encoder Lib "DMC2210.dll" (ByVal axis As Short) As Integer  '读取编码器反馈脉冲计数值

    Declare Function d2210_get_position Lib "DMC2210.dll" (ByVal axis As Short) As Integer  '读取指定轴的指令脉冲位置

    Declare Sub d2210_set_encoder Lib "DMC2210.dll" (ByVal axis As Short, ByVal encoder_value As Integer)  '设置编码器反馈脉冲计数值

    Declare Sub d2210_set_position Lib "DMC2210.dll" (ByVal axis As Short, ByVal current_position As Integer)  '设定指定轴的当前位置

    Declare Sub d2210_decel_stop Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Tdec As Double)

    Declare Sub d2210_variety_speed_range Lib "DMC2210.dll" (ByVal axis As Integer, ByVal chg_enable As Integer, ByVal Max_Vel As Double)

    Declare Sub d2210_change_speed Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Curr_Vel As Double)


End Module
