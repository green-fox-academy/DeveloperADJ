class HomeController < ApplicationController

	def index
		@projects = Project.all
		@teams = Team.all
	end

end
