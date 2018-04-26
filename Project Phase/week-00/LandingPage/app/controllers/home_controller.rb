class HomeController < ApplicationController

	def index
		@projects = Project.all
		@teams = Team.all
		@apprentices = Apprentice.all
	end

end
