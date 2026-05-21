# Copyright (c) 2026 David A. Frischknecht
#
# SPDX-License-Identifier: Apache-2.0

cmake_minimum_required(VERSION 3.28)
project(FNDice)

set(CMAKE_CXX_STANDARD 20)

find_package(wxWidgets REQUIRED net gl core base webview)
include(${wxWidgets_USE_FILE})

# Define common sources
set(FNDICE_SOURCES App.cpp App.h MainWindow.cpp MainWindow.h)

# Conditional add_executable for Windows
if(WIN32)
	add_executable(FNDice WIN32 FNDice.rc ${FNDICE_SOURCES})
endif()

# Conditional add_executable for Linux
if(UNIX AND NOT WIN32)
	add_executable(FNDice ${FNDICE_SOURCES})
endif()

target_link_libraries(FNDice PRIVATE ${wxWidgets_LIBRARIES})
target_precompile_headers(FNDice PRIVATE <wx/wxprec.h>)
