<template>
  <article class="w-full">
    <div class="flex items-center justify-between">
      <p>{{title}}</p>
      <IconButton :icon="collapsedIcon" @onClick="collapsed()"/>
    </div>
      <div class="" v-if="!isCollapsed">
        <slot/>
      </div>
  </article>
</template>

<script>
export default {
  name: "Dropdown",
  props: {
    title: 'Example'
  },
  data() {
    return {
      isCollapsed: true,
    }
  },
  methods: {
    collapsed() {
      this.isCollapsed = !this.isCollapsed
      this.$emit('collapsed');
    }
  },
  computed: {
    collapsedIcon() {
      return this.isCollapsed ? 'ri-arrow-left-s-line' : 'ri-arrow-down-s-line'
    }
  }
}
</script>

<style>
</style>
