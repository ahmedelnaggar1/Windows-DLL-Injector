#include "stdafx.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
		case DLL_PROCESS_ATTACH:
		{
			MessageBoxA(NULL, "Works!", "Dll injected successfully!", MB_OK);
			break;
		}
		case DLL_THREAD_ATTACH:
		{
			MessageBoxA(NULL, "Works!", "Dll injected successfully!", MB_OK);
			break;
		}
		case DLL_THREAD_DETACH:
		case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

