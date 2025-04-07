#Copyright (c) 2025 David A. Frischknecht
#
#SPDX-License-Identifier: Apache-2.0

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
endif ()
