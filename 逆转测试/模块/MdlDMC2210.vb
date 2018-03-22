Option Explicit On

Module MdlDMC2210

    '''                 初始化函数                      
    Declare Function d2210_board_init Lib "DMC2210.dll" () As Integer
    Declare Sub d2210_board_close Lib "DMC2210.dll" ()


    '脉冲输入输出配置
    Declare Sub d2210_set_pulse_outmode Lib "DMC2210.dll" (ByVal axis As Integer, ByVal outmode As Integer)

    '专用信号设置函数
    Declare Sub d2210_config_SD_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal enable As Integer, ByVal sd_logic As Integer, ByVal sd_mode As Integer)
    Declare Sub d2210_config_PCS_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal enable As Integer, ByVal pcs_logic As Integer)
    Declare Sub d2210_config_INP_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal enable As Integer, ByVal inp_logic As Integer)
    Declare Sub d2210_config_ERC_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal enable As Integer, ByVal erc_logic As Integer, ByVal erc_width As Integer, ByVal erc_off_time As Integer)
    Declare Sub d2210_config_ALM_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal alm_logic As Integer, ByVal alm_action As Integer)
    Declare Sub d2210_config_EL_MODE Lib "DMC2210.dll" (ByVal axis As Integer, ByVal el_mode As Integer)
    Declare Sub d2210_set_HOME_pin_logic Lib "DMC2210.dll" (ByVal axis As Integer, ByVal org_logic As Integer, ByVal filter As Integer)

    Declare Function d2210_read_SEVON_PIN Lib "DMC2210.dll" (ByVal axis As Integer) As Long
    Declare Sub d2210_write_SEVON_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal on_off As Integer)
    Declare Sub d2210_write_ERC_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal sel As Integer)
    Declare Function d2210_read_RDY_PIN Lib "DMC2210.dll" (ByVal axis As Integer) As Long

    '通用输入/输出控制函数
    Declare Function d2210_read_inbit Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal BitNo As Integer) As Long
    Declare Sub d2210_write_outbit Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal BitNo As Integer, ByVal on_off As Integer)
    Declare Function d2210_read_outbit Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal BitNo As Integer) As Long
    Declare Function d2210_read_inport Lib "DMC2210.dll" (ByVal card As Integer) As Long
    Declare Function d2210_read_outport Lib "DMC2210.dll" (ByVal card As Integer) As Long
    Declare Sub d2210_write_outport Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal Port_Value As Long)


    '找原点
    Declare Sub d2210_config_home_mode Lib "DMC2210.dll" (ByVal axis As Integer, ByVal mode As Integer, ByVal EZ_count As Integer)
    Declare Sub d2210_home_move Lib "DMC2210.dll" (ByVal axis As Integer, ByVal home_mode As Integer, ByVal vel_mode As Integer)

    '制动函数
    Declare Sub d2210_decel_stop Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Tdec As Double)
    Declare Sub d2210_imd_stop Lib "DMC2210.dll" (ByVal axis As Integer)
    Declare Sub d2210_emg_stop Lib "DMC2210.dll" ()
    Declare Sub d2210_simultaneous_stop Lib "DMC2210.dll" (ByVal axis As Integer)

    '位置设置和读取函数
    Declare Function d2210_get_position Lib "DMC2210.dll" (ByVal axis As Integer) As Long
    Declare Sub d2210_set_position Lib "DMC2210.dll" (ByVal axis As Integer, ByVal current_position As Long)

    '状态检测函数
    Declare Function d2210_check_done Lib "DMC2210.dll" (ByVal axis As Integer) As Integer
    Declare Function d2210_prebuff_status Lib "DMC2210.dll" (ByVal axis As Integer) As Integer
    Declare Function d2210_axis_io_status Lib "DMC2210.dll" (ByVal axis As Integer) As Integer
    Declare Function d2210_axis_status Lib "DMC2210.dll" (ByVal axis As Integer) As Integer
    Declare Function d2210_get_rsts Lib "DMC2210.dll" (ByVal axis As Integer) As Long

    '单轴定长运动
    Declare Sub d2210_t_pmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist As Long, ByVal posi_mode As Integer)
    Declare Sub d2210_ex_t_pmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist As Long, ByVal posi_mode As Integer)
    Declare Sub d2210_s_pmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist As Long, ByVal posi_mode As Integer)
    Declare Sub d2210_ex_s_pmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist As Long, ByVal posi_mode As Integer)

    '单轴连续运动
    Declare Sub d2210_s_vmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dir As Integer)
    Declare Sub d2210_t_vmove Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dir As Integer)


    '速度设置
    Declare Sub d2210_variety_speed_range Lib "DMC2210.dll" (ByVal axis As Integer, ByVal chg_enable As Integer, ByVal Max_Vel As Double)
    Declare Function d2210_read_current_speed Lib "DMC2210.dll" (ByVal axis As Integer) As Double
    Declare Sub d2210_change_speed Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Curr_Vel As Double)
    Declare Sub d2210_set_vector_profile Lib "DMC2210.dll" (ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double)
    Declare Sub d2210_set_profile Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double)
    Declare Sub d2210_set_s_profile Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double, ByVal Sacc As Long, ByVal Sdec As Long)
    Declare Sub d2210_set_st_profile Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Min_Vel As Double, ByVal Max_Vel As Double, ByVal Tacc As Double, ByVal Tdec As Double, ByVal Tsacc As Double, ByVal Tsdec As Double)

    Declare Sub d2210_reset_target_position Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist As Long)

    '线性插补
    Declare Sub d2210_t_line2 Lib "DMC2210.dll" (ByVal AXIS1 As Integer, ByVal Dist1 As Long, ByVal AXIS2 As Integer, ByVal Dist2 As Long, ByVal posi_mode As Integer)
    Declare Sub d2210_t_line3 Lib "DMC2210.dll" (ByVal axis As Integer, ByVal Dist1 As Long, ByVal Dist2 As Long, ByVal Dist3 As Long, ByVal posi_mode As Integer)
    Declare Sub d2210_t_line4 Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal Dist1 As Long, ByVal Dist2 As Long, ByVal Dist3 As Long, ByVal Dist4 As Long, ByVal posi_mode As Integer)

    '圆弧插补
    Declare Sub d2210_arc_move Lib "DMC2210.dll" (ByVal axis As Integer, ByVal target_pos As Long, ByVal cen_pos As Long, ByVal arc_dir As Integer)
    Declare Sub d2210_rel_arc_move Lib "DMC2210.dll" (ByVal axis As Integer, ByVal target_pos As Long, ByVal cen_pos As Long, ByVal arc_dir As Integer)


    '手轮运动
    Declare Sub d2210_set_handwheel_inmode Lib "DMC2210.dll" (ByVal axis As Integer, ByVal inmode As Integer, ByVal count_dir As Integer)
    Declare Sub d2210_handwheel_move Lib "DMC2210.dll" (ByVal axis As Integer, ByVal vh As Double)


    '//---------------------   编码器计数功能PLD  ----------------------//
    Declare Function d2210_get_encoder Lib "DMC2210.dll" (ByVal axis As Integer) As Integer
    Declare Sub d2210_set_encoder Lib "DMC2210.dll" (ByVal axis As Integer, ByVal encoder_value As Long)

    Declare Sub d2210_counter_config Lib "DMC2210.dll" (ByVal axis As Integer, ByVal mode As Integer)
    Declare Sub d2210_config_LTC_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal ltc_logic As Integer, ByVal ltc_mode As Integer)

    Declare Function d2210_get_latch_value Lib "DMC2210.dll" (ByVal axis As Integer) As Long

    Declare Function d2210_get_latch_flag Lib "DMC2210.dll" (ByVal cardno As Integer) As Long
    Declare Sub d2210_reset_latch_flag Lib "DMC2210.dll" (ByVal cardno As Integer)

    Declare Function d2210_get_counter_flag Lib "DMC2210.dll" (ByVal cardno As Integer) As Long
    Declare Sub d2210_reset_counter_flag Lib "DMC2210.dll" (ByVal cardno As Integer)

    Declare Sub d2210_reset_clear_flag Lib "DMC2210.dll" (ByVal cardno As Integer)

    '//---------------------   DMC2200新加功能 ----------------------//
    Declare Sub d2210_config_EZ_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal ez_logic As Integer, ByVal ez_mode As Integer)

    Declare Sub d2210_config_latch_mode Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal all_enable As Integer)

    Declare Sub d2210_triger_chunnel Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal num As Integer)

    Declare Sub d2210_set_speaker_logic Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal logic As Integer)

    Declare Sub d2210_config_EMG_PIN Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal enable As Integer, ByVal emg_logic As Integer)

    Declare Sub d2210_config_LTC_filter Lib "DMC2210.dll" (ByVal cardno As Integer, ByVal width As Integer, ByVal enable As Integer)
    Declare Sub d2210_config_encoder_filter Lib "DMC2210.dll" (ByVal axis As Integer, ByVal width As Integer, ByVal enable As Integer)

    '位置比较输出
    Declare Function d2210_read_CMP_PIN Lib "DMC2210.dll" (ByVal axis As Integer) As Long
    Declare Sub d2210_write_CMP_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal on_off As Integer)
    Declare Sub d2210_config_CMP_PIN Lib "DMC2210.dll" (ByVal axis As Integer, ByVal cmp1_enable As Integer, ByVal cmp2_enable As Integer, ByVal CMP_logic As Integer)

    Declare Sub d2210_config_comparator Lib "DMC2210.dll" (ByVal axis As Integer, ByVal cmp1_condition As Integer, ByVal cmp2_condition As Integer, ByVal source_sel As Integer, ByVal SL_action As Integer)
    Declare Sub d2210_set_comparator_data Lib "DMC2210.dll" (ByVal axis As Integer, ByVal cmp1_data As Long, ByVal cmp2_data As Long)


    '不同脉冲当量的圆弧插补
    Declare Function d2210_get_equiv Lib "DMC2210.dll" (ByVal axis As Integer, ByRef equiv As Double) As Long
    Declare Function d2210_set_equiv Lib "DMC2210.dll" (ByVal axis As Integer, ByVal new_equiv As Double) As Long

    Declare Sub d2210_arc_move_unitmm Lib "DMC2210.dll" (ByRef axis As Integer, ByRef target_pos As Double, ByRef cen_pos As Double, ByVal arc_dir As Integer)
    Declare Sub d2210_rel_arc_move_unitmm Lib "DMC2210.dll" (ByRef axis As Integer, ByRef rel_pos As Double, ByRef rel_cen As Double, ByVal arc_dir As Integer)


    '//增加同时起停操作
    Declare Function d2210_set_t_move_all Lib "DMC2210.dll" (ByVal TotalAxes As Integer, ByRef pAxis As Integer, ByRef pDist As Long, ByVal posi_mode As Integer) As Long
    Declare Function d2210_start_move_all Lib "DMC2210.dll" (ByVal FirstAxis As Integer) As Long

    Declare Function d2210_set_sync_option Lib "DMC2210.dll" (ByVal axis As Integer, ByVal sync_stop_on As Integer, ByVal cstop_output_on As Integer, ByVal sync_option1 As Integer, ByVal sync_option2 As Integer) As Long
    Declare Function d2210_set_sync_stop_mode Lib "DMC2210.dll" (ByVal axis As Integer, ByVal stop_mode As Integer) As Long


    Declare Function d2210_read_event_int_factor Lib "DMC2210.dll" (ByVal axis As Integer) As Long
    Declare Function d2210_get_lib_version Lib "DMC2210.dll" (ByRef libVer As Long, ByRef subVer As Long) As Long


End Module
