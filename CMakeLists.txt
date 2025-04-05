cmake_minimum_required(VERSION 3.30)
project(FNDice)

set(CMAKE_CXX_STANDARD 20)

find_package(wxWidgets REQUIRED net gl core base webview)
include(${wxWidgets_USE_FILE})

add_executable(FNDice WIN32
		App.cpp
		App.h
		MainWindow.cpp
		MainWindow.h)
target_link_libraries(FNDice PRIVATE ${wxWidgets_LIBRARIES})
target_precompile_headers(FNDice PRIVATE <wx/wxprec.h>)

if (${WIN32})
	target_sources(FNDice PRIVATE FNDice.rc)
	add_custom_command(
		TARGET FNDice POST_BUILD
		COMMAND ${CMAKE_COMMAND} -E copy
		"$ENV{WXWIN}/3rdparty/webview2/runtimes/win-x64/native/WebView2Loader.dll"
		"$<TARGET_FILE_DIR:FNDice>"
	)
endif ()
